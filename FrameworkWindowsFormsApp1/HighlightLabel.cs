using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkWindowsFormsApp1
{
    /// <summary>
    /// 高亮标签：当光标进入标签时，其背景色会显示；当光标离开标签时，其背景色会淡出
    /// </summary>
    internal class HighlightLabel : Label
    {
        private static readonly int s_backColorAlphaDecreaseIntervalInMilliseconds = 10;

        private static readonly int s_maxBackColorAlpha = 255;
        private static readonly int s_backColorAlphaDecrement = 15;
        private static readonly int s_minBackColorAlpha = 0;

        private int _backColoralpha;
        private CancellationTokenSource _backColorFadeOutCancellationTokenSource;

        /// <summary>
        /// 构造高亮标签
        /// </summary>
        public HighlightLabel()
        {
            MouseEnter += HighlightLabel_MouseEnter;            
            MouseLeave += HighlightLabel_MouseLeave;
        }

        protected override void InitLayout()
        {
            base.InitLayout();

            SetTransparentBackColor();
        }

        private void SetTransparentBackColor() => BackColor = Color.FromArgb(s_minBackColorAlpha, BackColor);

        private void HighlightLabel_MouseEnter(object sender, EventArgs e)
        {
            TryCancelFadeOutBackColor();
            SetOpaqueBackColor();            
        }

        private void TryCancelFadeOutBackColor()
        {
            if (_backColorFadeOutCancellationTokenSource != null)
            {
                _backColorFadeOutCancellationTokenSource.Cancel();
                _backColorFadeOutCancellationTokenSource.Dispose();
            }
        }

        private void SetOpaqueBackColor() => BackColor = Color.FromArgb(s_maxBackColorAlpha, BackColor);

        private void HighlightLabel_MouseLeave(object sender, EventArgs e) => FadeOutBackColor();

        private void FadeOutBackColor()
        {
            _backColorFadeOutCancellationTokenSource = new CancellationTokenSource();
            _backColoralpha = BackColor.A;

            DecreaseBackColorAlpha();
        }

        private void DecreaseBackColorAlpha()
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
                    if (_backColoralpha < s_minBackColorAlpha)
                    {
                        _backColoralpha = s_minBackColorAlpha;
                    }

                    Invoke((Action)(() => BackColor = Color.FromArgb(_backColoralpha, BackColor)));
                }, _backColorFadeOutCancellationTokenSource.Token);

            if (_backColoralpha > s_minBackColorAlpha && !_backColorFadeOutCancellationTokenSource.IsCancellationRequested)
            {
                task.ContinueWith(t => DecreaseBackColorAlpha(), _backColorFadeOutCancellationTokenSource.Token);
            }
        }
    }
}
