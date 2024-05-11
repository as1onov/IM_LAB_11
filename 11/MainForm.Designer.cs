namespace Lab11.NormalDistribution
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.varBox = new System.Windows.Forms.TextBox();
            this.varLabel = new System.Windows.Forms.Label();
            this.meanBox = new System.Windows.Forms.TextBox();
            this.meanLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SlateGray;
            this.mainPanel.Controls.Add(this.startBtn);
            this.mainPanel.Controls.Add(this.sizeBox);
            this.mainPanel.Controls.Add(this.sizeLabel);
            this.mainPanel.Controls.Add(this.varBox);
            this.mainPanel.Controls.Add(this.varLabel);
            this.mainPanel.Controls.Add(this.meanBox);
            this.mainPanel.Controls.Add(this.meanLabel);
            this.mainPanel.Location = new System.Drawing.Point(13, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(406, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.startBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(123, 374);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(159, 55);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeBox.Location = new System.Drawing.Point(166, 224);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(116, 26);
            this.sizeBox.TabIndex = 5;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(84, 224);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(52, 22);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Size:";
            // 
            // varBox
            // 
            this.varBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varBox.Location = new System.Drawing.Point(166, 133);
            this.varBox.Name = "varBox";
            this.varBox.Size = new System.Drawing.Size(116, 26);
            this.varBox.TabIndex = 3;
            // 
            // varLabel
            // 
            this.varLabel.AutoSize = true;
            this.varLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varLabel.Location = new System.Drawing.Point(31, 133);
            this.varLabel.Name = "varLabel";
            this.varLabel.Size = new System.Drawing.Size(88, 22);
            this.varLabel.TabIndex = 2;
            this.varLabel.Text = "Variance:";
            // 
            // meanBox
            // 
            this.meanBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meanBox.Location = new System.Drawing.Point(166, 42);
            this.meanBox.Name = "meanBox";
            this.meanBox.Size = new System.Drawing.Size(116, 26);
            this.meanBox.TabIndex = 1;
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meanLabel.Location = new System.Drawing.Point(69, 42);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(61, 22);
            this.meanLabel.TabIndex = 0;
            this.meanLabel.Text = "Mean:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(432, 478);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "NormalDistribution";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label meanLabel;
		private System.Windows.Forms.TextBox meanBox;
		private System.Windows.Forms.TextBox sizeBox;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.TextBox varBox;
		private System.Windows.Forms.Label varLabel;
		private System.Windows.Forms.Button startBtn;
	}
}

