
namespace VeriYapilariProje
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
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.rtxtbxResult = new System.Windows.Forms.RichTextBox();
            this.rtxtbxResultKelimees = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHashBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Enabled = false;
            this.filePath.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filePath.Location = new System.Drawing.Point(307, 82);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(217, 20);
            this.filePath.TabIndex = 0;
            this.filePath.Text = "Lütfen .txt uzantılı dosya seçiniz.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(365, 106);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dosya Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(164, 450);
            this.btnStackOku.Margin = new System.Windows.Forms.Padding(2);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(79, 40);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Stack İşlemi";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // rtxtbxResult
            // 
            this.rtxtbxResult.Location = new System.Drawing.Point(70, 216);
            this.rtxtbxResult.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResult.Name = "rtxtbxResult";
            this.rtxtbxResult.Size = new System.Drawing.Size(295, 228);
            this.rtxtbxResult.TabIndex = 3;
            this.rtxtbxResult.Text = "";
            // 
            // rtxtbxResultKelimees
            // 
            this.rtxtbxResultKelimees.Location = new System.Drawing.Point(473, 216);
            this.rtxtbxResultKelimees.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResultKelimees.Name = "rtxtbxResultKelimees";
            this.rtxtbxResultKelimees.Size = new System.Drawing.Size(298, 229);
            this.rtxtbxResultKelimees.TabIndex = 4;
            this.rtxtbxResultKelimees.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Heap İşlemi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHashBTN
            // 
            this.txtHashBTN.Location = new System.Drawing.Point(675, 450);
            this.txtHashBTN.Name = "txtHashBTN";
            this.txtHashBTN.Size = new System.Drawing.Size(96, 39);
            this.txtHashBTN.TabIndex = 6;
            this.txtHashBTN.Text = "Hash İşlemi";
            this.txtHashBTN.UseVisualStyleBackColor = true;
            this.txtHashBTN.Click += new System.EventHandler(this.txtHashBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(675, 496);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 528);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHashBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtbxResultKelimees);
            this.Controls.Add(this.rtxtbxResult);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.filePath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.RichTextBox rtxtbxResult;
        private System.Windows.Forms.RichTextBox rtxtbxResultKelimees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtHashBTN;
        private System.Windows.Forms.TextBox textBox1;
    }
}

