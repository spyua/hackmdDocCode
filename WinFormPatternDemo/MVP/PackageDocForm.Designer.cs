
namespace MVP
{
    partial class PackageDocForm
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
            this.Label_Product = new System.Windows.Forms.Label();
            this.Label_DocNo = new System.Windows.Forms.Label();
            this.Label_Yield = new System.Windows.Forms.Label();
            this.Label_NGYield = new System.Windows.Forms.Label();
            this.TextBox_Product = new System.Windows.Forms.TextBox();
            this.TextBox_DocNo = new System.Windows.Forms.TextBox();
            this.TextBox_Yield = new System.Windows.Forms.TextBox();
            this.TextBox_NGYield = new System.Windows.Forms.TextBox();
            this.ListBox_PackDoc = new System.Windows.Forms.ListBox();
            this.Label_PackageDocListTitle = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Product
            // 
            this.Label_Product.AutoSize = true;
            this.Label_Product.Location = new System.Drawing.Point(281, 61);
            this.Label_Product.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_Product.Name = "Label_Product";
            this.Label_Product.Size = new System.Drawing.Size(69, 20);
            this.Label_Product.TabIndex = 0;
            this.Label_Product.Text = "Product";
            // 
            // Label_DocNo
            // 
            this.Label_DocNo.AutoSize = true;
            this.Label_DocNo.Location = new System.Drawing.Point(281, 101);
            this.Label_DocNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_DocNo.Name = "Label_DocNo";
            this.Label_DocNo.Size = new System.Drawing.Size(66, 20);
            this.Label_DocNo.TabIndex = 1;
            this.Label_DocNo.Text = "Doc No";
            // 
            // Label_Yield
            // 
            this.Label_Yield.AutoSize = true;
            this.Label_Yield.Location = new System.Drawing.Point(281, 140);
            this.Label_Yield.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_Yield.Name = "Label_Yield";
            this.Label_Yield.Size = new System.Drawing.Size(46, 20);
            this.Label_Yield.TabIndex = 2;
            this.Label_Yield.Text = "Yield";
            // 
            // Label_NGYield
            // 
            this.Label_NGYield.AutoSize = true;
            this.Label_NGYield.Location = new System.Drawing.Point(281, 187);
            this.Label_NGYield.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_NGYield.Name = "Label_NGYield";
            this.Label_NGYield.Size = new System.Drawing.Size(75, 20);
            this.Label_NGYield.TabIndex = 3;
            this.Label_NGYield.Text = "NG Yield";
            // 
            // TextBox_Product
            // 
            this.TextBox_Product.Location = new System.Drawing.Point(358, 58);
            this.TextBox_Product.Name = "TextBox_Product";
            this.TextBox_Product.Size = new System.Drawing.Size(100, 29);
            this.TextBox_Product.TabIndex = 4;
            // 
            // TextBox_DocNo
            // 
            this.TextBox_DocNo.Location = new System.Drawing.Point(358, 98);
            this.TextBox_DocNo.Name = "TextBox_DocNo";
            this.TextBox_DocNo.Size = new System.Drawing.Size(100, 29);
            this.TextBox_DocNo.TabIndex = 5;
            // 
            // TextBox_Yield
            // 
            this.TextBox_Yield.Location = new System.Drawing.Point(358, 140);
            this.TextBox_Yield.Name = "TextBox_Yield";
            this.TextBox_Yield.Size = new System.Drawing.Size(100, 29);
            this.TextBox_Yield.TabIndex = 6;
            this.TextBox_Yield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Yield_KeyPress);
            // 
            // TextBox_NGYield
            // 
            this.TextBox_NGYield.Location = new System.Drawing.Point(358, 184);
            this.TextBox_NGYield.Name = "TextBox_NGYield";
            this.TextBox_NGYield.Size = new System.Drawing.Size(100, 29);
            this.TextBox_NGYield.TabIndex = 7;
            this.TextBox_NGYield.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_NGYield_KeyPress);
            // 
            // ListBox_PackDoc
            // 
            this.ListBox_PackDoc.FormattingEnabled = true;
            this.ListBox_PackDoc.ItemHeight = 20;
            this.ListBox_PackDoc.Location = new System.Drawing.Point(26, 58);
            this.ListBox_PackDoc.Name = "ListBox_PackDoc";
            this.ListBox_PackDoc.Size = new System.Drawing.Size(237, 244);
            this.ListBox_PackDoc.TabIndex = 8;
            this.ListBox_PackDoc.SelectedIndexChanged += new System.EventHandler(this.ListBox_PackDoc_SelectedIndexChanged);
            // 
            // Label_PackageDocListTitle
            // 
            this.Label_PackageDocListTitle.AutoSize = true;
            this.Label_PackageDocListTitle.Location = new System.Drawing.Point(26, 26);
            this.Label_PackageDocListTitle.Name = "Label_PackageDocListTitle";
            this.Label_PackageDocListTitle.Size = new System.Drawing.Size(95, 20);
            this.Label_PackageDocListTitle.TabIndex = 9;
            this.Label_PackageDocListTitle.Text = "Doc No List";
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(281, 233);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 29);
            this.Button_Save.TabIndex = 10;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(281, 273);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 29);
            this.Button_Delete.TabIndex = 11;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // PackageDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 330);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Label_PackageDocListTitle);
            this.Controls.Add(this.ListBox_PackDoc);
            this.Controls.Add(this.TextBox_NGYield);
            this.Controls.Add(this.TextBox_Yield);
            this.Controls.Add(this.TextBox_DocNo);
            this.Controls.Add(this.TextBox_Product);
            this.Controls.Add(this.Label_NGYield);
            this.Controls.Add(this.Label_Yield);
            this.Controls.Add(this.Label_DocNo);
            this.Controls.Add(this.Label_Product);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PackageDocForm";
            this.Text = "PackageDocForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Product;
        private System.Windows.Forms.Label Label_DocNo;
        private System.Windows.Forms.Label Label_Yield;
        private System.Windows.Forms.Label Label_NGYield;
        private System.Windows.Forms.TextBox TextBox_Product;
        private System.Windows.Forms.TextBox TextBox_DocNo;
        private System.Windows.Forms.TextBox TextBox_Yield;
        private System.Windows.Forms.TextBox TextBox_NGYield;
        private System.Windows.Forms.ListBox ListBox_PackDoc;
        private System.Windows.Forms.Label Label_PackageDocListTitle;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Delete;
    }
}

