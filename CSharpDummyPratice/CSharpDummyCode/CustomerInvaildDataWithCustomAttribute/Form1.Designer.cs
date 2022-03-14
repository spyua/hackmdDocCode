
namespace CustomerInvaildDataWithCustomAttribute
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_LoginName = new System.Windows.Forms.TextBox();
            this.label_loginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LoginAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LoginFeature = new System.Windows.Forms.TextBox();
            this.button_Snd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_LoginName
            // 
            this.textBox_LoginName.Location = new System.Drawing.Point(75, 48);
            this.textBox_LoginName.Name = "textBox_LoginName";
            this.textBox_LoginName.Size = new System.Drawing.Size(100, 22);
            this.textBox_LoginName.TabIndex = 0;
            // 
            // label_loginName
            // 
            this.label_loginName.AutoSize = true;
            this.label_loginName.Location = new System.Drawing.Point(36, 52);
            this.label_loginName.Name = "label_loginName";
            this.label_loginName.Size = new System.Drawing.Size(32, 12);
            this.label_loginName.TabIndex = 1;
            this.label_loginName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age";
            // 
            // textBox_LoginAge
            // 
            this.textBox_LoginAge.Location = new System.Drawing.Point(75, 99);
            this.textBox_LoginAge.Name = "textBox_LoginAge";
            this.textBox_LoginAge.Size = new System.Drawing.Size(100, 22);
            this.textBox_LoginAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feature";
            // 
            // textBox_LoginFeature
            // 
            this.textBox_LoginFeature.Location = new System.Drawing.Point(75, 150);
            this.textBox_LoginFeature.Name = "textBox_LoginFeature";
            this.textBox_LoginFeature.Size = new System.Drawing.Size(100, 22);
            this.textBox_LoginFeature.TabIndex = 5;
            // 
            // button_Snd
            // 
            this.button_Snd.Location = new System.Drawing.Point(100, 197);
            this.button_Snd.Name = "button_Snd";
            this.button_Snd.Size = new System.Drawing.Size(75, 23);
            this.button_Snd.TabIndex = 6;
            this.button_Snd.Text = "送出";
            this.button_Snd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Snd);
            this.Controls.Add(this.textBox_LoginFeature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_LoginAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_loginName);
            this.Controls.Add(this.textBox_LoginName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_LoginName;
        private System.Windows.Forms.Label label_loginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LoginAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LoginFeature;
        private System.Windows.Forms.Button button_Snd;
    }
}

