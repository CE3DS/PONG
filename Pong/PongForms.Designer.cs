
namespace Pong
{
    partial class Pong
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NPCBox = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.Target = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.tmMovement = new System.Windows.Forms.Timer(this.components);
            this.tmTarget = new System.Windows.Forms.Timer(this.components);
            this.tmNPC = new System.Windows.Forms.Timer(this.components);
            this.lbPlayerScore = new System.Windows.Forms.Label();
            this.lbNPCScore = new System.Windows.Forms.Label();
            this.lblResetScore = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarCoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clrBackground = new System.Windows.Forms.ColorDialog();
            this.clrHUD = new System.Windows.Forms.ColorDialog();
            this.clrPlayer = new System.Windows.Forms.ColorDialog();
            this.tmBackgroundColor = new System.Windows.Forms.Timer(this.components);
            this.tmHUDColor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NPCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NPCBox
            // 
            this.NPCBox.BackColor = System.Drawing.Color.Black;
            this.NPCBox.Location = new System.Drawing.Point(700, 200);
            this.NPCBox.Name = "NPCBox";
            this.NPCBox.Size = new System.Drawing.Size(20, 100);
            this.NPCBox.TabIndex = 0;
            this.NPCBox.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.Black;
            this.PlayerBox.Location = new System.Drawing.Point(100, 200);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(20, 100);
            this.PlayerBox.TabIndex = 1;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.LocationChanged += new System.EventHandler(this.PlayerBox_LocationChanged);
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.Black;
            this.Target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Target.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Target.Location = new System.Drawing.Point(390, 240);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(20, 20);
            this.Target.TabIndex = 2;
            this.Target.TabStop = false;
            this.Target.LocationChanged += new System.EventHandler(this.Target_LocationChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(264, 150);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(273, 62);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Move to Start";
            // 
            // tmMovement
            // 
            this.tmMovement.Interval = 10;
            this.tmMovement.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // tmTarget
            // 
            this.tmTarget.Interval = 10;
            this.tmTarget.Tick += new System.EventHandler(this.tmTarget_Tick);
            // 
            // tmNPC
            // 
            this.tmNPC.Interval = 10;
            this.tmNPC.Tick += new System.EventHandler(this.tmNPC_Tick);
            // 
            // lbPlayerScore
            // 
            this.lbPlayerScore.AutoSize = true;
            this.lbPlayerScore.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerScore.Location = new System.Drawing.Point(12, 35);
            this.lbPlayerScore.Name = "lbPlayerScore";
            this.lbPlayerScore.Size = new System.Drawing.Size(60, 47);
            this.lbPlayerScore.TabIndex = 10;
            this.lbPlayerScore.Text = "00";
            // 
            // lbNPCScore
            // 
            this.lbNPCScore.AutoSize = true;
            this.lbNPCScore.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNPCScore.Location = new System.Drawing.Point(728, 35);
            this.lbNPCScore.Name = "lbNPCScore";
            this.lbNPCScore.Size = new System.Drawing.Size(60, 47);
            this.lbNPCScore.TabIndex = 11;
            this.lbNPCScore.Text = "00";
            // 
            // lblResetScore
            // 
            this.lblResetScore.AutoSize = true;
            this.lblResetScore.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetScore.Location = new System.Drawing.Point(329, 200);
            this.lblResetScore.Name = "lblResetScore";
            this.lblResetScore.Size = new System.Drawing.Size(147, 21);
            this.lblResetScore.TabIndex = 12;
            this.lblResetScore.Text = "or press \"R\" to restart";
            this.lblResetScore.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mudarCoresToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.configuraçõesToolStripMenuItem.Text = "Opções";
            // 
            // mudarCoresToolStripMenuItem
            // 
            this.mudarCoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.HUDToolStripMenuItem});
            this.mudarCoresToolStripMenuItem.Name = "mudarCoresToolStripMenuItem";
            this.mudarCoresToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mudarCoresToolStripMenuItem.Text = "Mudar Cores";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // HUDToolStripMenuItem
            // 
            this.HUDToolStripMenuItem.Name = "HUDToolStripMenuItem";
            this.HUDToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.HUDToolStripMenuItem.Text = "HUD";
            this.HUDToolStripMenuItem.Click += new System.EventHandler(this.HUDToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tmBackgroundColor
            // 
            this.tmBackgroundColor.Tick += new System.EventHandler(this.tmBackgroundColor_Tick);
            // 
            // tmHUDColor
            // 
            this.tmHUDColor.Tick += new System.EventHandler(this.tmHUDColor_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblResetScore);
            this.Controls.Add(this.lbNPCScore);
            this.Controls.Add(this.lbPlayerScore);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.NPCBox);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.Target);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NPCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NPCBox;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Timer tmMovement;
        private System.Windows.Forms.Timer tmTarget;
        private System.Windows.Forms.Timer tmNPC;
        private System.Windows.Forms.Label lbPlayerScore;
        private System.Windows.Forms.Label lbNPCScore;
        private System.Windows.Forms.Label lblResetScore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarCoresToolStripMenuItem;
        private System.Windows.Forms.ColorDialog clrBackground;
        private System.Windows.Forms.ColorDialog clrHUD;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HUDToolStripMenuItem;
        private System.Windows.Forms.ColorDialog clrPlayer;
        private System.Windows.Forms.Timer tmBackgroundColor;
        private System.Windows.Forms.Timer tmHUDColor;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}