const urlGeneralInfo = 'https://api.github.com/users/httpsgabi';
let dadosGerais = []; 

const urlRepoInfo = 'https://api.github.com/users/httpsgabi/repos';
let dadosRepo = [];

const urlFollowersInfo = 'https://api.github.com/users/httpsgabi/followers';
let dadosFollower = [];

function CarregaDadosAPI_Gerais(func) {
    fetch(urlGeneralInfo, { headers })
        .then(response => response.json())
        .then(dados => {
            dadosGerais = dados;
            func(dadosGerais); 
        });
}

function CarregaDadosAPI_Repo(func) {
    fetch(urlRepoInfo, { headers })
        .then(response => response.json())
        .then(dados => {
            dadosRepo = dados;
            func(dadosRepo);  
        });
}

function CarregaDadosAPI_Followers(func) {
    fetch(urlFollowersInfo, { headers })
        .then(response => response.json())
        .then(dados => {
            dadosFollower = dados;
            func(dadosFollower);
        });
}
