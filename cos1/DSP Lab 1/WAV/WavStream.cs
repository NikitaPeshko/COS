using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace DSP.Lab1.Presentation.WAV
{
    internal class WavStream : ISampleProvider
    {
        public WaveFormat WaveFormat { get; set; }
        private List<float> Samples { get; set; }

        private int _offset = 0;

        public WavStream(WaveFormat waveFormat, List<float> samples)
        {
            WaveFormat = waveFormat;
            Samples = samples;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            count = Math.Min(count, Samples.Count - _offset);
            for (var i = 0; i < count; i++)
            {
                buffer[offset + i] = Samples[_offset + i];
            }
            _offset += count;
            return count;
        }
    }
}