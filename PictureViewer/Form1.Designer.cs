
namespace PictureViewer
{
    partial class ImageViewer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyTable = new System.Windows.Forms.TableLayoutPanel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.show_pic = new System.Windows.Forms.Button();
            this.clear_pic = new System.Windows.Forms.Button();
            this.set_back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MyTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyTable
            // 
            this.MyTable.BackColor = System.Drawing.SystemColors.Window;
            this.MyTable.ColumnCount = 2;
            this.MyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.18027F));
            this.MyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.81973F));
            this.MyTable.Controls.Add(this.pb, 0, 0);
            this.MyTable.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.MyTable.Controls.Add(this.checkBox1, 0, 1);
            this.MyTable.Location = new System.Drawing.Point(0, 0);
            this.MyTable.Name = "MyTable";
            this.MyTable.RowCount = 2;
            this.MyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MyTable.Size = new System.Drawing.Size(527, 423);
            this.MyTable.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MyTable.SetColumnSpan(this.pb, 2);
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(3, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(521, 374);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.show_pic);
            this.flowLayoutPanel1.Controls.Add(this.clear_pic);
            this.flowLayoutPanel1.Controls.Add(this.set_back);
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 383);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(441, 37);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // show_pic
            // 
            this.show_pic.BackColor = System.Drawing.Color.LightGreen;
            this.show_pic.Location = new System.Drawing.Point(356, 3);
            this.show_pic.Name = "show_pic";
            this.show_pic.Size = new System.Drawing.Size(82, 31);
            this.show_pic.TabIndex = 0;
            this.show_pic.Text = "Show pic";
            this.show_pic.UseVisualStyleBackColor = false;
            this.show_pic.Click += new System.EventHandler(this.show_pic_Click);
            // 
            // clear_pic
            // 
            this.clear_pic.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clear_pic.Location = new System.Drawing.Point(233, 3);
            this.clear_pic.Name = "clear_pic";
            this.clear_pic.Size = new System.Drawing.Size(117, 31);
            this.clear_pic.TabIndex = 1;
            this.clear_pic.Text = "Clear pic";
            this.clear_pic.UseVisualStyleBackColor = false;
            this.clear_pic.Click += new System.EventHandler(this.clear_pic_Click);
            // 
            // set_back
            // 
            this.set_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.set_back.Location = new System.Drawing.Point(99, 3);
            this.set_back.Name = "set_back";
            this.set_back.Size = new System.Drawing.Size(128, 31);
            this.set_back.TabIndex = 2;
            this.set_back.Text = "Set back";
            this.set_back.UseVisualStyleBackColor = false;
            this.set_back.Click += new System.EventHandler(this.set_back_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LightCoral;
            this.close.Location = new System.Drawing.Point(7, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(86, 31);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*" +
    "";
            this.openFileDialog1.Title = "Select a picture file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 423);
            this.Controls.Add(this.MyTable);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MyTable.ResumeLayout(false);
            this.MyTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MyTable;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button show_pic;
        private System.Windows.Forms.Button clear_pic;
        private System.Windows.Forms.Button set_back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

