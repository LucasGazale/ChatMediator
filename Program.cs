using System;
using MediatorSimples;

var grupo = new GrupoTrabalho();

var p1 = new Pessoa(grupo, "Ana");
var p2 = new Pessoa(grupo, "Bruno");
var p3 = new Pessoa(grupo, "Carlos");

grupo.Adicionar(p1);
grupo.Adicionar(p2);
grupo.Adicionar(p3);

// Testando a comunicação
p1.Mandar("Terminaram a parte de banco de dados?");
p2.Mandar("Ainda não, falta uma tabela.");

Console.ReadLine();
