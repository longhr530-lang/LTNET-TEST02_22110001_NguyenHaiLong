using System.Drawing;
using System.Windows.Forms;

namespace bai5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbControl = new GroupBox();
            btnStart = new Button();
            btnStop = new Button();
            gbRealtime = new GroupBox();
            lblTitleTemp = new Label();
            lblTemperature = new Label();
            dgvLogs = new DataGridView();
            statusStrip = new StatusStrip();
            lblConnectionStatus = new ToolStripStatusLabel();
            lblCycleCount = new ToolStripStatusLabel();
            gbControl.SuspendLayout();
            gbRealtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // gbControl
            // 
            gbControl.Controls.Add(btnStart);
            gbControl.Controls.Add(btnStop);
            gbControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbControl.Location = new Point(12, 12);
            gbControl.Name = "gbControl";
            gbControl.Size = new Size(776, 75);
            gbControl.TabIndex = 0;
            gbControl.TabStop = false;
            gbControl.Text = "Điều Khiển Giám Sát";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.Location = new Point(20, 28);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(160, 32);
            btnStart.TabIndex = 0;
            btnStart.Text = "Bắt Đầu Giám Sát";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.LightCoral;
            btnStop.Enabled = false;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStop.Location = new Point(200, 28);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(160, 32);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dừng Giám Sát";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // gbRealtime
            // 
            gbRealtime.Controls.Add(lblTitleTemp);
            gbRealtime.Controls.Add(lblTemperature);
            gbRealtime.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbRealtime.Location = new Point(12, 95);
            gbRealtime.Name = "gbRealtime";
            gbRealtime.Size = new Size(776, 110);
            gbRealtime.TabIndex = 1;
            gbRealtime.TabStop = false;
            gbRealtime.Text = "Hiển Thị Nhiệt Độ Cảm Biến Real-time";
            // 
            // lblTitleTemp
            // 
            lblTitleTemp.AutoSize = true;
            lblTitleTemp.Font = new Font("Segoe UI", 10F);
            lblTitleTemp.Location = new Point(20, 45);
            lblTitleTemp.Name = "lblTitleTemp";
            lblTitleTemp.Size = new Size(114, 19);
            lblTitleTemp.TabIndex = 0;
            lblTitleTemp.Text = "Nhiệt độ hiện tại:";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.Green;
            lblTemperature.Location = new Point(179, 31);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(125, 51);
            lblTemperature.TabIndex = 1;
            lblTemperature.Text = "--.- °C";
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.WhiteSmoke;
            dgvLogs.Font = new Font("Segoe UI", 9F);
            dgvLogs.Location = new Point(12, 215);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(776, 330);
            dgvLogs.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblConnectionStatus, lblCycleCount });
            statusStrip.Location = new Point(0, 558);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 3;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(148, 17);
            lblConnectionStatus.Text = "Trạng thái: Chưa kết nối  |  ";
            // 
            // lblCycleCount
            // 
            lblCycleCount.Name = "lblCycleCount";
            lblCycleCount.Size = new Size(100, 17);
            lblCycleCount.Text = "Số chu kỳ nhận: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(gbControl);
            Controls.Add(gbRealtime);
            Controls.Add(dgvLogs);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG GIÁM SÁT CẢNH BÁO IOT REAL-TIME";
            gbControl.ResumeLayout(false);
            gbRealtime.ResumeLayout(false);
            gbRealtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbControl = null!;
        private Button btnStart = null!;
        private Button btnStop = null!;

        private GroupBox gbRealtime = null!;
        private Label lblTitleTemp = null!;
        private Label lblTemperature = null!;

        private DataGridView dgvLogs = null!;

        private StatusStrip statusStrip = null!;
        private ToolStripStatusLabel lblConnectionStatus = null!;
        private ToolStripStatusLabel lblCycleCount = null!;
    }
}