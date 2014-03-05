namespace WindowsFormsApplication1
{
    partial class manualArray
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ArrayInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateArray = new System.Windows.Forms.Button();
            this.GenerateArray = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerateArray);
            this.groupBox1.Controls.Add(this.CreateArray);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ArrayInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание массива вручную";
            // 
            // ArrayInput
            // 
            this.ArrayInput.Location = new System.Drawing.Point(6, 40);
            this.ArrayInput.Name = "ArrayInput";
            this.ArrayInput.Size = new System.Drawing.Size(255, 20);
            this.ArrayInput.TabIndex = 2;
            this.ArrayInput.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите элементы массива, разделяя их пробелом";
            this.label2.Visible = false;
            // 
            // CreateArray
            // 
            this.CreateArray.Location = new System.Drawing.Point(6, 67);
            this.CreateArray.Name = "CreateArray";
            this.CreateArray.Size = new System.Drawing.Size(75, 23);
            this.CreateArray.TabIndex = 4;
            this.CreateArray.Text = "Создать";
            this.CreateArray.UseVisualStyleBackColor = true;
            this.CreateArray.Visible = false;
            this.CreateArray.Click += new System.EventHandler(this.CreateArray_Click);
            // 
            // GenerateArray
            // 
            this.GenerateArray.Location = new System.Drawing.Point(102, 67);
            this.GenerateArray.Name = "GenerateArray";
            this.GenerateArray.Size = new System.Drawing.Size(95, 23);
            this.GenerateArray.TabIndex = 5;
            this.GenerateArray.Text = "Гененрировать";
            this.GenerateArray.UseVisualStyleBackColor = true;
            this.GenerateArray.Visible = false;
            // 
            // manualArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 162);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "manualArray";
            this.Text = "manualArray";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GenerateArray;
        private System.Windows.Forms.Button CreateArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArrayInput;
    }
}