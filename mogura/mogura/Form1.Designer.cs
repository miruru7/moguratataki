namespace mogura
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Endbutton = new System.Windows.Forms.Button();
            this.levelScrollBar = new System.Windows.Forms.HScrollBar();
            this.levellabel = new System.Windows.Forms.Label();
            this.Pointlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(332, 506);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(80, 25);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "開始";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Endbutton
            // 
            this.Endbutton.Location = new System.Drawing.Point(413, 506);
            this.Endbutton.Name = "Endbutton";
            this.Endbutton.Size = new System.Drawing.Size(80, 25);
            this.Endbutton.TabIndex = 2;
            this.Endbutton.Text = "終了";
            this.Endbutton.UseVisualStyleBackColor = true;
            this.Endbutton.Click += new System.EventHandler(this.Endbutton_Click);
            // 
            // levelScrollBar
            // 
            this.levelScrollBar.LargeChange = 4;
            this.levelScrollBar.Location = new System.Drawing.Point(87, 506);
            this.levelScrollBar.Maximum = 33;
            this.levelScrollBar.Minimum = 1;
            this.levelScrollBar.Name = "levelScrollBar";
            this.levelScrollBar.Size = new System.Drawing.Size(175, 23);
            this.levelScrollBar.TabIndex = 3;
            this.levelScrollBar.Value = 1;
            this.levelScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.levelScrollBar_Scroll);
            // 
            // levellabel
            // 
            this.levellabel.BackColor = System.Drawing.SystemColors.Window;
            this.levellabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levellabel.Location = new System.Drawing.Point(303, 506);
            this.levellabel.Name = "levellabel";
            this.levellabel.Size = new System.Drawing.Size(23, 23);
            this.levellabel.TabIndex = 4;
            this.levellabel.Text = "1";
            this.levellabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pointlabel
            // 
            this.Pointlabel.BackColor = System.Drawing.SystemColors.Window;
            this.Pointlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pointlabel.Location = new System.Drawing.Point(12, 506);
            this.Pointlabel.Name = "Pointlabel";
            this.Pointlabel.Size = new System.Drawing.Size(25, 23);
            this.Pointlabel.TabIndex = 5;
            this.Pointlabel.Text = "0";
            this.Pointlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::mogura.Properties.Resources.地面;
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.Image = global::mogura.Properties.Resources.もぐら;
            this.Picture.Location = new System.Drawing.Point(142, 21);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(100, 134);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Visible = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "レベル";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pointlabel);
            this.Controls.Add(this.levellabel);
            this.Controls.Add(this.levelScrollBar);
            this.Controls.Add(this.Endbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "モグラたたきゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Endbutton;
        private System.Windows.Forms.HScrollBar levelScrollBar;
        private System.Windows.Forms.Label levellabel;
        private System.Windows.Forms.Label Pointlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

