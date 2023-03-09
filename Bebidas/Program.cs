using Bebidas;

Bebida bebida = new Bebida ();
Suco suco  = new Suco();
Refrigerante refrigerante  = new Refrigerante ();


Repositorio.AlterarBebida(bebida);


var listaAntesExcluir = Repositorio.Listar();


Repositorio.ExcluirBebida(1);


var listaApoxExcluir = Repositorio.Listar();


Repositorio.AdicionarBebida(bebida);
Repositorio.AdicionarSuco(suco);
Repositorio.AdicionarRefrigerante(refrigerante);


Repositorio.ImprimirRefrigerante();
Repositorio.ImprimirSuco();