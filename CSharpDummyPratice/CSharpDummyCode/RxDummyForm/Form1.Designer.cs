
namespace RxDummyForm
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
            this.SearchMeterBtn = new System.Windows.Forms.Button();
            this.SearchLightSourceTimeOut = new System.Windows.Forms.Button();
            this.SearchBothDevice = new System.Windows.Forms.Button();
            this.SearchConcat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchMeterBtn
            // 
            this.SearchMeterBtn.Location = new System.Drawing.Point(40, 27);
            this.SearchMeterBtn.Name = "SearchMeterBtn";
            this.SearchMeterBtn.Size = new System.Drawing.Size(246, 23);
            this.SearchMeterBtn.TabIndex = 0;
            this.SearchMeterBtn.Text = "SearchMeter";
            this.SearchMeterBtn.UseVisualStyleBackColor = true;
            this.SearchMeterBtn.Click += new System.EventHandler(this.SearchMeterTimeOut_Click);
            // 
            // SearchLightSourceTimeOut
            // 
            this.SearchLightSourceTimeOut.Location = new System.Drawing.Point(40, 72);
            this.SearchLightSourceTimeOut.Name = "SearchLightSourceTimeOut";
            this.SearchLightSourceTimeOut.Size = new System.Drawing.Size(246, 23);
            this.SearchLightSourceTimeOut.TabIndex = 1;
            this.SearchLightSourceTimeOut.Text = "SearchLightSourceTimeOut";
            this.SearchLightSourceTimeOut.UseVisualStyleBackColor = true;
            this.SearchLightSourceTimeOut.Click += new System.EventHandler(this.SearchLightSourceTimeOut_Click);
            // 
            // SearchBothDevice
            // 
            this.SearchBothDevice.Location = new System.Drawing.Point(40, 120);
            this.SearchBothDevice.Name = "SearchBothDevice";
            this.SearchBothDevice.Size = new System.Drawing.Size(246, 23);
            this.SearchBothDevice.TabIndex = 2;
            this.SearchBothDevice.Text = "SearchBothDevice";
            this.SearchBothDevice.UseVisualStyleBackColor = true;
            this.SearchBothDevice.Click += new System.EventHandler(this.SearchBothDevice_Click);
            // 
            // SearchConcat
            // 
            this.SearchConcat.Location = new System.Drawing.Point(40, 165);
            this.SearchConcat.Name = "SearchConcat";
            this.SearchConcat.Size = new System.Drawing.Size(246, 23);
            this.SearchConcat.TabIndex = 3;
            this.SearchConcat.Text = "SearchConcat";
            this.SearchConcat.UseVisualStyleBackColor = true;
            this.SearchConcat.Click += new System.EventHandler(this.SearchConcat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchConcat);
            this.Controls.Add(this.SearchBothDevice);
            this.Controls.Add(this.SearchLightSourceTimeOut);
            this.Controls.Add(this.SearchMeterBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchMeterBtn;
        private System.Windows.Forms.Button SearchLightSourceTimeOut;
        private System.Windows.Forms.Button SearchBothDevice;
        private System.Windows.Forms.Button SearchConcat;
    }
}

