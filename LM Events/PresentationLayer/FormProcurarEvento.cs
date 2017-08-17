using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events
{
    public partial class FormProcurarEvento : Form
    {

        public bool IniciaPorStand { get; set; }
        FormNovoStand recebestand = new FormNovoStand();
        public FormProcurarEvento(FormNovoStand dadosStand)
        {
            InitializeComponent();
            recebestand = dadosStand;
            dgvListaEvento.DataSource = new EventosDAL().GetEventosStands();
            if (dgvListaEvento == null)
            {
                MessageBox.Show("Nenhum evento eventos foi localizado.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            IniciaPorStand = true;
        }

        public bool IniciaPorEvento { get; set; }
        FormAtualizarEventos recebe = new FormAtualizarEventos();
        public FormProcurarEvento(FormAtualizarEventos dados)
        {
            InitializeComponent();
            recebe = dados;
            IniciaPorEvento = true;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IniciaPorEvento == true)
            {
                DBEvento EventoView = (DBEvento)dgvListaEvento.CurrentRow.DataBoundItem;
                recebe.EventoIdUp.Text = Convert.ToString(EventoView.EventoId);
                recebe.TextNomeEventoATu.Text = EventoView.NomeEvento;
                recebe.dateEventoFimupATU.Text = Convert.ToString(EventoView.DataFim);
                recebe.dateEventoInicioupATU.Text = Convert.ToString(EventoView.DataInicio);
                recebe.maskedHoraInicioEventoATU.Text = EventoView.HoraInicio;
                recebe.maskedHoraFimEventoATU.Text = EventoView.HoraFim;
                recebe.txtValorInscricaoATU.Text = Convert.ToString(EventoView.ValorEvento);
                recebe.CarregarComboTipoEvento();
                recebe.TextTipoEventoATU.SelectedValue = EventoView.TipoEvento_id;
                int id = EventoView.EnderecoEvento_id;
                EnderecoDAL EnderecoID = new EnderecoDAL();

                DBEndereco end = EnderecoID.GetEndereco(id);
                recebe.maskedCEPEventoupATU.Text = end.CEP;
                recebe.textCadastroRuaEventoupATU.Text = end.Rua;
                recebe.textCadastroBairroEventoupATU.Text = end.Bairro;
                recebe.textCadastroComplementoEventoupATu.Text = end.Complemento;
                recebe.textCadastroNumeroEventoupATU.Text = end.Numero;
                recebe.CarregarComboCidade();
                recebe.comboCadastroCidadeEventoupATU.SelectedValue = end.Cidade_id;
                recebe.CarregarComboEstado();
                recebe.comboCadastroUFEventoupATU.SelectedValue = end.Estado_id;
                this.Close();
                recebe.GrupocaxadadosEventos.Visible = true;
                recebe.GrupocaxaLocalEventos.Visible = true;
                return;
            }
            DataRowView EventoStand = (DataRowView)dgvListaEvento.CurrentRow.DataBoundItem;
            recebestand.textStandEvento.Text = EventoStand["Nome do Evento"].ToString();
            recebestand.textIdEvento.Text = Convert.ToString(EventoStand["Código do Evento"]);
            this.Close();

        }

        private void ProcurarEvento_Load(object sender, EventArgs e)
        {
            if (IniciaPorEvento == true)
            {
                if (dgvListaEvento == null)
                {
                    MessageBox.Show("Nenhum evento eventos foi localizado.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string eventosviw = recebe.textEventoBusca.Text;
                dgvListaEvento.DataSource = new EventosDAL().GetEventosLike(eventosviw);
            }
        }
    }
}
