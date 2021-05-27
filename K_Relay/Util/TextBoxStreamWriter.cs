﻿using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace K_Relay.Util
{
    public class TextBoxStreamWriter : TextWriter
    {
        private StringBuilder _buffer;
        private readonly RichTextBox _output;

        public TextBoxStreamWriter(RichTextBox output)
        {
            _buffer = new StringBuilder();
            _output = output;
        }

        public override Encoding Encoding => Encoding.UTF8;

        public override void Write(char value)
        {
            base.Write(value);
            _buffer.Append(value);

            if (value == '\n' || value == '\r')
            {
                if (_output.IsHandleCreated)
                    _output.Invoke(new MethodInvoker(() => _output.AppendText(_buffer.ToString())));
                else if (!_output.InvokeRequired)
                    _output.AppendText(_buffer.ToString());

                _buffer = new StringBuilder();
            }
        }
    }

    public class MetroTextBoxStreamWriter : TextWriter
    {
        private StringBuilder _buffer;
        private readonly MetroTextBox _output;

        public MetroTextBoxStreamWriter(MetroTextBox output)
        {
            _buffer = new StringBuilder();
            _output = output;
        }

        public override Encoding Encoding => Encoding.UTF8;

        public override void Write(char value)
        {
            base.Write(value);
            _buffer.Append(value);

            if (value == '\n' || value == '\r')
            {
                if (_output.IsHandleCreated)
                    _output.Invoke(new MethodInvoker(() => _output.AppendText(_buffer.ToString())));
                else if (!_output.InvokeRequired)
                    _output.AppendText(_buffer.ToString());

                _buffer = new StringBuilder();
            }
        }
    }
}