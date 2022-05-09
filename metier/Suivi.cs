﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class Suivi
    {
        private readonly int id;
        private readonly string libelle;
        /// <summary>
        /// Valorisation des propriété de la classe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Suivi(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        /// <summary>
        /// Get Id
        /// </summary>
        public int Id { get => id; }
        /// <summary>
        /// Get Libelle
        /// </summary>
        public string Libelle { get => libelle; }
    }
}
