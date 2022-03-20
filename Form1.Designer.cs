
namespace OsuBeatmapManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_BackDel = new System.Windows.Forms.Button();
            this.check_Backbackup = new System.Windows.Forms.CheckBox();
            this.But_VideoDel = new System.Windows.Forms.Button();
            this.check_VideoBackup = new System.Windows.Forms.CheckBox();
            this.but_BackBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_BackDel
            // 
            this.but_BackDel.Location = new System.Drawing.Point(12, 28);
            this.but_BackDel.Name = "but_BackDel";
            this.but_BackDel.Size = new System.Drawing.Size(75, 23);
            this.but_BackDel.TabIndex = 0;
            this.but_BackDel.Text = "배경 제거";
            this.but_BackDel.UseVisualStyleBackColor = true;
            this.but_BackDel.Click += new System.EventHandler(this.but_BackDel_Click);
            // 
            // check_Backbackup
            // 
            this.check_Backbackup.AutoSize = true;
            this.check_Backbackup.Location = new System.Drawing.Point(11, 64);
            this.check_Backbackup.Name = "check_Backbackup";
            this.check_Backbackup.Size = new System.Drawing.Size(140, 16);
            this.check_Backbackup.TabIndex = 1;
            this.check_Backbackup.Text = "배경 이미지 다운로드";
            this.check_Backbackup.UseVisualStyleBackColor = true;
            // 
            // But_VideoDel
            // 
            this.But_VideoDel.Location = new System.Drawing.Point(157, 28);
            this.But_VideoDel.Name = "But_VideoDel";
            this.But_VideoDel.Size = new System.Drawing.Size(81, 23);
            this.But_VideoDel.TabIndex = 2;
            this.But_VideoDel.Text = "동영상 제거";
            this.But_VideoDel.UseVisualStyleBackColor = true;
            this.But_VideoDel.Click += new System.EventHandler(this.But_VideoDel_Click);
            // 
            // check_VideoBackup
            // 
            this.check_VideoBackup.AutoSize = true;
            this.check_VideoBackup.Location = new System.Drawing.Point(157, 64);
            this.check_VideoBackup.Name = "check_VideoBackup";
            this.check_VideoBackup.Size = new System.Drawing.Size(112, 16);
            this.check_VideoBackup.TabIndex = 3;
            this.check_VideoBackup.Text = "동영상 다운로드";
            this.check_VideoBackup.UseVisualStyleBackColor = true;
            // 
            // but_BackBackup
            // 
            this.but_BackBackup.Location = new System.Drawing.Point(12, 86);
            this.but_BackBackup.Name = "but_BackBackup";
            this.but_BackBackup.Size = new System.Drawing.Size(75, 23);
            this.but_BackBackup.TabIndex = 4;
            this.but_BackBackup.Text = "배경 복구";
            this.but_BackBackup.UseVisualStyleBackColor = true;
            this.but_BackBackup.Click += new System.EventHandler(this.but_BackBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 139);
            this.Controls.Add(this.but_BackBackup);
            this.Controls.Add(this.check_VideoBackup);
            this.Controls.Add(this.But_VideoDel);
            this.Controls.Add(this.check_Backbackup);
            this.Controls.Add(this.but_BackDel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_BackDel;
        private System.Windows.Forms.CheckBox check_Backbackup;
        private System.Windows.Forms.Button But_VideoDel;
        private System.Windows.Forms.CheckBox check_VideoBackup;
        private System.Windows.Forms.Button but_BackBackup;
    }
}

