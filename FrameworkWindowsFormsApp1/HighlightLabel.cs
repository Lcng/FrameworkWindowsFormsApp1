using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkWindowsFormsApp1
{
    internal class HighlightLabel : Label
    {
        private static readonly int s_backColorAlphaDecreaseIntervalInMilliseconds = 10;

        private static readonly int s_maxBackColorAlpha = 255;
        private static readonly int s_backColorAlphaDecrement = 15;
        private static readonly int s_minBackColorAlpha = 0;

        private int _backColoralpha = s_maxBackColorAlpha;
        private CancellationTokenSource _backColorFadeOutCancellationTokenSource;

        public HighlightLabel()
        {
            MouseEnter += highlightLabel_MouseEnter;            
            MouseLeave += highlightLabel_MouseLeave;
        }

        private void highlightLabel_MouseEnter(object sender, EventArgs e)
        {
            if (_backColorFadeOutCancellationTokenSource != null)
            {
                _backColorFadeOutCancellationTokenSource.Cancel();
                _backColorFadeOutCancellationTokenSource.Dispose();
            }

            BackColor = Color.FromArgb(s_maxBackColorAlpha, Color.Red);
        }

        private void highlightLabel_MouseLeave(object sender, EventArgs e)
        {
            _backColorFadeOutCancellationTokenSource = new CancellationTokenSource();
            _backColoralpha = s_maxBackColorAlpha;

            BackColorFadeOut();
        }

        private void BackColorFadeOut()
        {
            Task task = Task
                .Delay(s_backColorAlphaDecreaseIntervalInMilliseconds, _backColorFadeOutCancellationTokenSource.Token)
                .ContinueWith(t =>
                {
                    if (_backColorFadeOutCancellationTokenSource.IsCancellationRequested)
                    {
                        return;
                    }

                    _backColoralpha = _backColoralpha - s_backColorAlphaDecrement;
                    if (_backColoralpha < 0)
                    {
                        _backColoralpha = 0;
                    }

                    Invoke((Action)(() => BackColor = Color.FromArgb(_backColoralpha, Color.Red)));
                }, _backColorFadeOutCancellationTokenSource.Token);

            if (_backColoralpha > 0 && !_backColorFadeOutCancellationTokenSource.IsCancellationRequested)
            {
                task.ContinueWith(t => BackColorFadeOut(), _backColorFadeOutCancellationTokenSource.Token);
            }
        }
    }
}
