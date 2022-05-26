﻿using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedBrainMVC2.View
{
    public partial class EventoControlView : UserControl
    {
        public EventoControlView()
        {
            InitializeComponent();
        }

        public string NomeEvento
        {
            get { return lblNome.Text.Trim(); }
            set { lblNome.Text = value; }
        }

        public string LocalEvento
        {
            get { return lblLocal.Text.Trim(); }
            set { lblLocal.Text = value; }
        }

        public string DescricaoEvento
        {
            get { return lblDescricao.Text.Trim(); }
            set { lblDescricao.Text = value; }
        }
        public DateTime DataInicio
        {
            get { return Convert.ToDateTime(lblDataInicio.Text); }
            set { lblDataInicio.Text = value.ToShortDateString(); }
        }

        public DateTime DataTermino
        {
            get { return Convert.ToDateTime(lblDataTermino.Text); }
            set { lblDataTermino.Text = value.ToShortDateString(); }
        }

        public string PeriodicidadeEvento
        {
            get { return lblPeriodicidade.Text.Trim(); }
            set { lblPeriodicidade.Text = value; }
        }

        public string StatusEvento
        {
            get { return lblStatus.Text.Trim(); }
            set { lblStatus.Text = value; }
        }

        public string Contatos
        {
            get { return lblContato.Text.Trim(); }
            set { lblContato.Text = value; }
        }

        public string Foto
        {
            get { return lnkFoto.Tag.ToString()!; }
            set { lnkFoto.Tag = value; }
        }

        public void SalvaEvento(Evento e)
        {
            NomeEvento = e.NomeEvento;
            LocalEvento = e.LocalEvento;
            DescricaoEvento = e.DescricaoEvento;
            DataInicio = e.DataInicio;
            DataTermino = e.DataTermino;
            PeriodicidadeEvento = e.Periodicidade;
            StatusEvento = e.Status;
            lnkFoto.Tag = e.Foto;
            Contatos = e.Contato;

            if (e.Status == "Concluido")
                lblNome.ForeColor = Color.Green;
            else if (e.Status == "Em Andamento")
                lblNome.ForeColor = Color.Blue;
            else
                lblNome.ForeColor = Color.Red;
        }

        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}