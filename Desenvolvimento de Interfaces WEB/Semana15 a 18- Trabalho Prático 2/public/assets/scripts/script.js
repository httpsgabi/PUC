const urlGeneralInfo = 'https://api.github.com/users/httpsgabi';
let dadosGerais = []; 

const urlRepoInfo = 'https://api.github.com/users/httpsgabi/repos';
let dadosRepo = [];

let dadosFollower = [];

let dadosCarrossel = [];

function CarregaDadosAPI_Gerais(func) {
    fetch(urlGeneralInfo)
        .then(response => response.json())
        .then(dados => {
            dadosGerais = dados;
            func(dadosGerais); 
        });
}

function CarregaDadosAPI_Repo(func) {
    fetch(urlRepoInfo)
        .then(response => response.json())
        .then(dados => {
            dadosRepo = dados;
            func(dadosRepo);  
        });
}

function CarregaDadosAPI_Followers(func) {
    fetch('https://api.github.com/users/ErickPedrosa')
        .then(response => response.json())
        .then(dados => {
            dadosFollower.push(dados);
            func(dadosFollower);
        });
    fetch('https://api.github.com/users/Julialunna')
    .then(response => response.json())
    .then(dados => {
        dadosFollower.push(dados);
        func(dadosFollower);
    });
    fetch('https://api.github.com/users/neffahr')
    .then(response => response.json())
    .then(dados => {
        dadosFollower.push(dados);
        func(dadosFollower);
    });
    
}

function CarregaDadosAPI_Carrossel(func){
    fetch('/carrossel')
    .then(response => response.json())
    .then(dados => {
       dadosCarrossel = dados;
        func(dadosCarrossel);
    });
}
