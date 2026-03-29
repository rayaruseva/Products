namespace Products
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиПродуктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.редактиранеToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.всичкиПродуктиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.добавиToolStripMenuItem.Text = "Добавяне";
            this.добавиToolStripMenuItem.Click += new System.EventHandler(this.добавиToolStripMenuItem_Click);
            // 
            // редактиранеToolStripMenuItem
            // 
            this.редактиранеToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.редактиранеToolStripMenuItem.Name = "редактиранеToolStripMenuItem";
            this.редактиранеToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.редактиранеToolStripMenuItem.Text = "Редактиране";
            this.редактиранеToolStripMenuItem.Click += new System.EventHandler(this.редактиранеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКоличествоToolStripMenuItem,
            this.поЦенаToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // поКоличествоToolStripMenuItem
            // 
            this.поКоличествоToolStripMenuItem.Name = "поКоличествоToolStripMenuItem";
            this.поКоличествоToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.поКоличествоToolStripMenuItem.Text = "По количество";
            this.поКоличествоToolStripMenuItem.Click += new System.EventHandler(this.поКоличествоToolStripMenuItem_Click);
            // 
            // поЦенаToolStripMenuItem
            // 
            this.поЦенаToolStripMenuItem.Name = "поЦенаToolStripMenuItem";
            this.поЦенаToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.поЦенаToolStripMenuItem.Text = "По цена";
            this.поЦенаToolStripMenuItem.Click += new System.EventHandler(this.поЦенаToolStripMenuItem_Click);
            // 
            // всичкиПродуктиToolStripMenuItem
            // 
            this.всичкиПродуктиToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.всичкиПродуктиToolStripMenuItem.Name = "всичкиПродуктиToolStripMenuItem";
            this.всичкиПродуктиToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.всичкиПродуктиToolStripMenuItem.Text = "Всички продукти";
            this.всичкиПродуктиToolStripMenuItem.Click += new System.EventHandler(this.всичкиПродуктиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 729);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦенаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиПродуктиToolStripMenuItem;
    }
}

