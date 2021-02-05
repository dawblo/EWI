
namespace EWI
{
    partial class Modify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.TextBox();
            this.box4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(219, 34);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(149, 22);
            this.box1.TabIndex = 1;
            this.box1.TextChanged += new System.EventHandler(this.box1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa ewidencyjna";
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(219, 73);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(149, 22);
            this.box2.TabIndex = 3;
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(219, 153);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(149, 22);
            this.box4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(219, 114);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(149, 22);
            this.box3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Producent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(219, 191);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(149, 22);
            this.box5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Name = "Modify";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox box1;
        public System.Windows.Forms.TextBox box2;
        public System.Windows.Forms.TextBox box4;
        public System.Windows.Forms.TextBox box3;
        public System.Windows.Forms.TextBox box5;
    }
}