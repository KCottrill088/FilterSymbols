﻿namespace FilterSymbols.Models
{
    public class SymbolModel
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool IsEnabled { get; set; }
        public string Type { get; set; }
        public string IexId { get; set; }
    }
}
