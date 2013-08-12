namespace Kohenon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.learningRate = new System.Windows.Forms.TextBox();
            this.w00 = new System.Windows.Forms.TextBox();
            this.w01 = new System.Windows.Forms.TextBox();
            this.w10 = new System.Windows.Forms.TextBox();
            this.w11 = new System.Windows.Forms.TextBox();
            this.w20 = new System.Windows.Forms.TextBox();
            this.w21 = new System.Windows.Forms.TextBox();
            this.w30 = new System.Windows.Forms.TextBox();
            this.w31 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.i0 = new System.Windows.Forms.TextBox();
            this.i1 = new System.Windows.Forms.TextBox();
            this.i2 = new System.Windows.Forms.TextBox();
            this.i3 = new System.Windows.Forms.TextBox();
            this.epochInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // learningRate
            // 
            resources.ApplyResources(this.learningRate, "learningRate");
            this.learningRate.Name = "learningRate";
            // 
            // w00
            // 
            resources.ApplyResources(this.w00, "w00");
            this.w00.Name = "w00";
            // 
            // w01
            // 
            resources.ApplyResources(this.w01, "w01");
            this.w01.Name = "w01";
            // 
            // w10
            // 
            resources.ApplyResources(this.w10, "w10");
            this.w10.Name = "w10";
            // 
            // w11
            // 
            resources.ApplyResources(this.w11, "w11");
            this.w11.Name = "w11";
            // 
            // w20
            // 
            resources.ApplyResources(this.w20, "w20");
            this.w20.Name = "w20";
            // 
            // w21
            // 
            resources.ApplyResources(this.w21, "w21");
            this.w21.Name = "w21";
            // 
            // w30
            // 
            resources.ApplyResources(this.w30, "w30");
            this.w30.Name = "w30";
            // 
            // w31
            // 
            resources.ApplyResources(this.w31, "w31");
            this.w31.Name = "w31";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // i0
            // 
            resources.ApplyResources(this.i0, "i0");
            this.i0.Name = "i0";
            // 
            // i1
            // 
            resources.ApplyResources(this.i1, "i1");
            this.i1.Name = "i1";
            // 
            // i2
            // 
            resources.ApplyResources(this.i2, "i2");
            this.i2.Name = "i2";
            // 
            // i3
            // 
            resources.ApplyResources(this.i3, "i3");
            this.i3.Name = "i3";
            // 
            // epochInput
            // 
            resources.ApplyResources(this.epochInput, "epochInput");
            this.epochInput.Name = "epochInput";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.epochInput);
            this.Controls.Add(this.i3);
            this.Controls.Add(this.i2);
            this.Controls.Add(this.i1);
            this.Controls.Add(this.i0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.w31);
            this.Controls.Add(this.w30);
            this.Controls.Add(this.w21);
            this.Controls.Add(this.w20);
            this.Controls.Add(this.w11);
            this.Controls.Add(this.w10);
            this.Controls.Add(this.w01);
            this.Controls.Add(this.w00);
            this.Controls.Add(this.learningRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learningRate;
        private System.Windows.Forms.TextBox w00;
        private System.Windows.Forms.TextBox w01;
        private System.Windows.Forms.TextBox w10;
        private System.Windows.Forms.TextBox w11;
        private System.Windows.Forms.TextBox w20;
        private System.Windows.Forms.TextBox w21;
        private System.Windows.Forms.TextBox w30;
        private System.Windows.Forms.TextBox w31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox i0;
        private System.Windows.Forms.TextBox i1;
        private System.Windows.Forms.TextBox i2;
        private System.Windows.Forms.TextBox i3;
        private System.Windows.Forms.TextBox epochInput;
    }
}

