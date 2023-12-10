﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Models
{
    public class TransacaoModel
    {
        public int? Id { get; set; }

        public string? Historico { get; set; }

        public int PlanocontaId { get; set; }
        public string? Tipo { get; set; }

        public DateTime Data { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [NotMapped]
        public string? Descricao { get; set; }

        public IEnumerable<PlanoContaModel>? PlanocontaList { get; set; }

        public IEnumerable<SelectListItem>? PlanoContaSelectList { get; set; }
    }
}