using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class CMForm : Form
    {
        public CMForm()
        {
            InitializeComponent();
        }

        //初始化
        private void AppStart(object sender, EventArgs e)
        {
            HelpToolTip.SetToolTip(CaptionTextBox, "设置消息框的标题。点击左侧标签了解更多。");
            HelpToolTip.SetToolTip(ContentTextBox, "设置消息框的文字内容。点击左侧标签了解更多。");
            HelpToolTip.SetToolTip(IconComboBox, "设置消息框中的图标。点击左侧标签了解更多。");
            HelpToolTip.SetToolTip(ButtonsComboBox, "设置消息框的按钮。点击左侧标签了解更多。");
            HelpToolTip.SetToolTip(OptionsComboBox, "设置消息框的布局。点击左侧标签了解更多。");
        }
        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //创建消息框
        private void CreateMessageBox(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ContentTextBox.Text, CaptionTextBox.Text, GetButtons(ButtonsComboBox?.SelectedIndex), GetIcon(IconComboBox?.SelectedIndex), MessageBoxDefaultButton.Button1, GetOptions(OptionsComboBox?.SelectedIndex));
            }
            catch (Exception err)
            {

            }
        }

        //图标
        private MessageBoxIcon GetIcon(int? Index)
        {
            try
            {
                switch (Index)
                {
                    case 0:
                        {
                            return MessageBoxIcon.Asterisk;
                        }
                    case 1:
                        {
                            return MessageBoxIcon.Error;
                        }
                    case 2:
                        {
                            return MessageBoxIcon.Exclamation;
                        }
                    case 3:
                        {
                            return MessageBoxIcon.Hand;
                        }
                    case 4:
                        {
                            return MessageBoxIcon.Information;
                        }
                    case 5:
                        {
                            return MessageBoxIcon.None;
                        }
                    case 6:
                        {
                            return MessageBoxIcon.Question;
                        }
                    case 7:
                        {
                            return MessageBoxIcon.Stop;
                        }
                    case 8:
                        {
                            return MessageBoxIcon.Warning;
                        }
                    default:
                        {
                            return MessageBoxIcon.Error;
                        }
                }
            }
            catch (Exception err)
            {
                return MessageBoxIcon.None;
            }
        }

        //按钮
        private MessageBoxButtons GetButtons(int? Index)
        {
            try
            {
                switch (Index)
                {
                    case 0:
                        {
                            return MessageBoxButtons.AbortRetryIgnore;
                        }
                    case 1:
                        {
                            return MessageBoxButtons.OK;
                        }
                    case 2:
                        {
                            return MessageBoxButtons.OKCancel;
                        }
                    case 3:
                        {
                            return MessageBoxButtons.RetryCancel;
                        }
                    case 4:
                        {
                            return MessageBoxButtons.YesNo;
                        }
                    case 5:
                        {
                            return MessageBoxButtons.YesNoCancel;
                        }
                    default:
                        {
                            return MessageBoxButtons.OK;
                        }
                }
            }
            catch (Exception err)
            {
                return MessageBoxButtons.OK;
            }
        }

        //选项
        private MessageBoxOptions GetOptions(int? Index)
        {
            try
            {
                switch (Index)
                {
                    case 0:
                        {
                            return 0;
                        }
                    case 1:
                        {
                            return MessageBoxOptions.DefaultDesktopOnly;
                        }
                    case 2:
                        {
                            return MessageBoxOptions.RightAlign;
                        }
                    case 3:
                        {
                            return MessageBoxOptions.RtlReading;
                        }
                    case 4:
                        {
                            return MessageBoxOptions.ServiceNotification;
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
            catch (Exception err)
            {
                return 0;
            }
        }

        //链接到帮助页面
        private void GetHelp(object sender, EventArgs e)
        {
            try
            {
                if (sender == CaptionLabel|| sender == ContentLabel)
                {
                    System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=netframework-4.7.2");
                }
                if (sender == IconLabel)
                {
                    System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxicon?view=netframework-4.7.2");
                }
                if (sender == ButtonsLabel)
                {
                    System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxbuttons?view=netframework-4.7.2");
                }
                if (sender == OptionsLabel)
                {
                    System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxoptions?view=netframework-4.7.2");
                }
            }
            catch (Exception err)
            {

            }

        }
    }  
}
