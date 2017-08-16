function TesteInterface() {

    this.testeTexto = ko.observable();
    this.testeArray = ko.observableArray();
    this.testeTexto2 = ko.observable();

    this.Iniciar();

};

TesteInterface.prototype.Iniciar = function () {
    
    this.testeTexto("Olá Mundo, Teste de acentuação com ko... Ç %$#@");

    this.testeArray([
        { valor: "texto1" },
        { valor: "texto2" }
    ]);
   
    this.testeTexto2("teste");
};

(function () {
    ko.applyBindings(new TesteInterface(), document.getElementById('teste'));
})();
