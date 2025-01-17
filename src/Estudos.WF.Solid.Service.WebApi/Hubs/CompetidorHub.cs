﻿using Estudos.WF.Solid.Core.Entities;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Estudos.WF.Solid.Service.WebApi.Hubs
{
    [HubName("CompetidorHub")]
    public class CompetidorHub : Hub
    {
        private readonly string nomeDoGrupo = "Torneio";

        public string JoinTournament(string nomeDoLutador)
        {
            Groups.Add(nomeDoLutador, nomeDoGrupo);
            return $"{nomeDoLutador} joined {nomeDoGrupo}";
        }

        public string LeaveTournament(string nomeDoLutador)
        {
            Groups.Remove(nomeDoLutador, nomeDoGrupo);
            return $"{nomeDoLutador} removed {nomeDoGrupo}";
        }

        public void DisplayMessageAll(string message)
        {
            Clients.All.DisplayMessageAll($"Clients.All from {Context.ConnectionId}: {message}");
        }

        public void CadastrarLutadorNoTorneio(Lutador lutador)
        {
            Clients.All.LutadorAdicionado(lutador);
        }
    }
}