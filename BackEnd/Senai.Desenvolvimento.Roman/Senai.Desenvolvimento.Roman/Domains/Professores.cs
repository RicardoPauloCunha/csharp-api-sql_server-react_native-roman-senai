﻿using System;
using System.Collections.Generic;

namespace Senai.Desenvolvimento.Roman.Domains
{
    public partial class Professores
    {
        public int ProfessorId { get; set; }
        public int IdUsuario { get; set; }
        public int IdEquipe { get; set; }

        public Equipes IdEquipeNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}