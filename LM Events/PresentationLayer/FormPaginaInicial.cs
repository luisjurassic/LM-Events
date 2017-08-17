using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.GUI;
using LM_Events.PresentationLayer;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LM_Events
{
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            InitializeComponent();

        }
        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            labelUserLogado.Text = Parametros.GetUser().Usuario;

            int permissao = Parametros.GetAcesso().Permissao_id;
            if (permissao == 2)
            {
                this.administraçãoToolStripMenuItem.Visible = true;
            }
            //statusStatus.Text = "Bem vindo!";
        }

        #region Itens do MENU pagina inicial
        private void sobreOLMEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobreLMEvents sobreOprograma = new FormSobreLMEvents();
            sobreOprograma.ShowDialog();
        }
        private void toolBarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;

        }
        private void statusBarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;

        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivoDialog = new OpenFileDialog();
            abrirArquivoDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            abrirArquivoDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (abrirArquivoDialog.ShowDialog(this) == DialogResult.OK)
            {
                string arquivoNome = abrirArquivoDialog.FileName;
            }
        }
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Sair do LM Events?", "Fechar LM Events", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rlt == DialogResult.Yes)
            {
                for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
                {
                    if (Application.OpenForms[intIndex] != this)
                        Application.OpenForms[intIndex].Close();
                }
                this.Close();
            }
        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPessoaJuridica cadastrarempresas = new FormCadastroPessoaJuridica();
            cadastrarempresas.ShowDialog();
        }
        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPessoaFisica pf = new FormCadastroPessoaFisica();
            pf.ShowDialog();
        }
        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoUsuario newUser = new FormNovoUsuario();
            newUser.ShowDialog();
        }
        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministracaoUsuario adminUser = new FormAdministracaoUsuario();
            adminUser.ShowDialog();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddd', 'dd' de 'MMMM' de 'yyyy  -");
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }
        public void toolStripLabelLogoff_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente fazer Logout?", "Logout de Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
                new FormLogin().Show();
            }
        }
        private void novoEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoEvento newEvento = new FormNovoEvento();
            newEvento.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void descontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrarDescontos descontos = new FormAdministrarDescontos();
            descontos.ShowDialog();
        }
        private void labelUserLogado_Click(object sender, EventArgs e)
        {
            FormSobreUsuario aboutUser = new FormSobreUsuario();
            aboutUser.ShowDialog();
        }
        private void listaDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalendarEventos lEventos = new FormCalendarEventos();
            lEventos.ShowDialog();
        }
        private void inscriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaInscricao pg = new FormNovaInscricao();
            pg.ShowDialog();
        }
        private void auterarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarEventos atualizarEvento = new FormAtualizarEventos();
            atualizarEvento.ShowDialog();
        }
        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagamento pag = new FormPagamento();
            pag.ShowDialog();
        }
        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastroPessoaFisica atualizarPF = new FormAtualizarCadastroPessoaFisica();
            atualizarPF.ShowDialog();
        }
        private void empresaToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FormAtualizarCadastroPessoaJuridica atualizarPJ = new FormAtualizarCadastroPessoaJuridica();
            atualizarPJ.ShowDialog();
        }
        private void cancelarInscriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirInscricao delInscricoes = new FormExcluirInscricao();
            delInscricoes.ShowDialog();
        }
        private void cancelamentoDeEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirEvento eve = new FormExcluirEvento();
            eve.ShowDialog();
        }
        private void listaDeExcluidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrosExcluidos cancelains = new FormCadastrosExcluidos();
            cancelains.ShowDialog();
        }
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirCadastro formExcluirCadastro = new FormExcluirCadastro();
            formExcluirCadastro.ShowDialog();
        }
        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFecharCaixa caixa = new FormFecharCaixa();
            caixa.ShowDialog();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }
        private void eventosCanceladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEventosExcluidos eexclu = new FormEventosExcluidos();
            eexclu.ShowDialog();
        }
        private void inscricõesCanceladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscricoesExcluidos inscricoesExcluidas = new FormInscricoesExcluidos();
            inscricoesExcluidas.ShowDialog();
        }
        private void alterarOuExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministracaoStands stand = new FormAdministracaoStands();
            stand.ShowDialog();
        }
        private void inserirStandSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoStand newStand = new FormNovoStand();
            newStand.ShowDialog();
        }
        private void iniciarCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Iniciar caixa? Todos os valores seram perdidos.";
            string titlle = "Atenção!";
            DialogResult res = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                new CaixaDAL().iniciarCaixa();
                MessageBox.Show("Caixa iniciado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void reservarStandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservaStand r = new FormReservaStand();
            r.ShowDialog();
        }
        private void standsReservadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStandReservado reser = new FormStandReservado();
            reser.ShowDialog();
        }
        private void cancelarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirReserva r = new FormExcluirReserva();
            r.ShowDialog();
        }
        private void listaDeInscriçõesEfetuadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscricaoReservada ir = new FormInscricaoReservada();
            ir.ShowDialog();
        }
        #endregion
    
    }
}
