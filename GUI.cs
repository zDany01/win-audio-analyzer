using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wasapi;
using NAudio.Wave;

namespace win_audio_analyzer
{
    public partial class GUI : Form
    {
        private const string REPO_URL = "https://github.com/zDany01/win-audio-analyzer";
        private const string TOGGLE_PAUSE_TEXT = "Pause Capture";
        private const string TOGGLE_PLAY_TEXT = "Resume Capture";
        private readonly MMDeviceEnumerator audioDevices = new MMDeviceEnumerator();
        private readonly DirectSoundOut speaker = new DirectSoundOut();
        private WasapiLoopbackCapture recorder;
        private BufferedWaveProvider recordedWave;

        public GUI()
        {
            InitializeComponent();
            this.Load += GUI_Load;
            this.refreshToolStripMenuItem.Click += (_, __) => UpdateSources();
            this.exitToolStripMenuItem.Click += (_, __) => Application.Exit();
            this.optionsToolStripMenuItem.Click += (_, __) => new SettingsForm().ShowDialog();
            this.repoToolStripMenuItem.Click += (_, __) => Process.Start(REPO_URL);
            this.aboutToolStripMenuItem.Click += (_, __) => new AboutForm().Show();
            this.audioRbt.CheckedChanged += (_, __) => UpdateSources();
            this.recordBtn.Click += SelectAudioSource;
            this.stopBtn.Click += (_, __) => StopRecording();
            this.pauseBtn.Click += ToggleRecording;
            this.playbackCbx.CheckedChanged += TogglePlayback;
        }

        private void UpdateSources(bool selectDefault = false)
        {
            sourcesCbx.SelectedItem = null;
            sourcesCbx.Items.Clear();
            if (audioRbt.Checked)
            {
#if DEBUG
                MMDeviceCollection devices = audioDevices.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
                Debug.WriteLine($"Found {devices.Count} devices");
                foreach (MMDevice dev in devices)
                {
                    Debug.WriteLine($"- {dev.FriendlyName}");
                    sourcesCbx.Items.Add(dev);
                }

#else
                sourcesCbx.Items.AddRange(audioDevices.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray<MMDevice>());
#endif
                MMDevice defaultOutput = audioDevices.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                if (selectDefault) sourcesCbx.SelectedItem = sourcesCbx.Items.Cast<MMDevice>().Where(p => p.DeviceFriendlyName == defaultOutput.DeviceFriendlyName).First();

            }
            else throw new NotImplementedException();
        }
        private void StopRecording()
        {
            if (recorder is null) return;
#if DEBUG
            Debug.WriteLine("Recorder found: Stopping and Disposing");
#endif
            recorder.StopRecording();
            recorder.Dispose();
            recorder = null;
            recordedWave = null;
            pauseBtn.Text = TOGGLE_PAUSE_TEXT;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            UpdateSources(true);
            pauseBtn.Text = TOGGLE_PAUSE_TEXT;
        }
        private void AnalyzeAudio(object sender, WaveInEventArgs e)
        {
            recordedWave.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }
        private void SelectAudioSource(object sender, EventArgs e)
        {
            StopRecording();
            recorder = new WasapiLoopbackCapture((MMDevice)sourcesCbx.SelectedItem);
            recordedWave = new BufferedWaveProvider(recorder.WaveFormat);
            speaker.Init(recordedWave);
            recorder.DataAvailable += AnalyzeAudio;
#if DEBUG
            Debug.WriteLine($"Loaded new audio source: {((MMDevice)sourcesCbx.SelectedItem).FriendlyName}");
#endif
            recorder.StartRecording();
            if(playbackCbx.Checked) speaker.Play();
        }
        private void ToggleRecording(object sender, EventArgs e)
        {
            if (recorder is null) return;

            if (object.ReferenceEquals(pauseBtn.Text, TOGGLE_PAUSE_TEXT))
            {
                recorder.StopRecording();
                speaker.Stop();
                recordedWave.ClearBuffer();
                pauseBtn.Text = TOGGLE_PLAY_TEXT;
            }
            else
            {
                recorder.StartRecording();
                speaker.Play();
                pauseBtn.Text = TOGGLE_PAUSE_TEXT;
            }
        }

        private void TogglePlayback(object sender, EventArgs e)
        {
            switch (speaker.PlaybackState)
            {
                case PlaybackState.Playing:
                    speaker.Pause();
                    break;
                case PlaybackState.Paused:
                case PlaybackState.Stopped:
                    recordedWave?.ClearBuffer();
                    speaker.Play();
                    break;
            }
        }
    }
}
