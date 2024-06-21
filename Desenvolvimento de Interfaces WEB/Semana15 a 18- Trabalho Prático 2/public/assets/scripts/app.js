function CarregaTela() {
    // Função que carrega todos os dados referentes às informações gerais do perfil
    function CarregaDadosGerais(dadosGerais) { 
        var nomeUsuarioHeader = document.getElementById('name_user');
        var fotoPerfil = document.getElementById('foto_perfil');
        var nomeUsuarioFooter = document.getElementById('name_user_footer');
       
        nomeUsuarioHeader.innerHTML = `<h1 class="name_user py-2 px-5">${dadosGerais.name}</h1>`;
        fotoPerfil.src = dadosGerais.avatar_url;
        fotoPerfil.alt = 'Foto de perfil do usuário';
        nomeUsuarioFooter.innerHTML = `<p>&copy; Copyright | 2024, ${dadosGerais.name}, Código de Pessoa: 1524475</p>`;

    }

    // Função que carrega todos os dados referentes às informações da parte de perfil
    function CarregaDadosPerfil(dadosGerais){
        var perfilGit = document.getElementById('perfilUser');

        perfilGit.innerHTML = `
        <h3 class="text-info mb-3">${dadosGerais.name}</h3>
        <p class="mb-3">${dadosGerais.bio}</p>
        
        <p class="col-11 mb-3 p-0 d-flex"><strong>Location: </strong> ${dadosGerais.location}</p>
        
        <div class="d-flex align-items-center mb-3">
            <img src="assets/icons/pessoas.svg" alt="Ícone de pessoas que seguem este perfil" class="me-2">
            <p class="m-0"> ${dadosGerais.followers} followers</p>
        </div>    
    
        <p class="mb-3"><strong>Site:</strong> <a href="${dadosGerais.html_url}" class="text-info" target="_blank">${dadosGerais.html_url}</a></p>
    `;
    
    }

    // Função que carrega todos os dados referentes às informações gerais dos repositórios
    function CarregaDadosRepo(dadosRepo) { 
        var quantRepositorios = document.getElementById('quant_repositorios');
        quantRepositorios.innerHTML = `<h2>Repositórios (${dadosRepo.length})</h2>`;
        var repositorios = document.getElementById('cards_api');
    
        var strTextRepositorios = '';
        
        for (let i = 0; i < dadosRepo.length; i++) {
            strTextRepositorios += `
                <div class="col-sm-12 col-md-6 col-lg-3 mb-3">
                    <div class="card border-info h-100">
                        <div class="card-header"><a href="repo.html?id=${dadosRepo[i].id}">${dadosRepo[i].name}</a></div>
                        <div class="card-body text-info">
                            <h5 class="card-title">${dadosRepo[i].description}</h5>
                            <div class="icons d-flex justify-content-between">
                                <div>
                                    <img src="assets/icons/favoritos.svg" alt="Icone de Favoritos">
                                    <p class="d-inline pr-3">${dadosRepo[i].stargazers_count}</p>
                                </div>
                                <div>
                                    <img src="assets/icons/pessoas.svg" alt="Icone de Pessoas">
                                    <p class="d-inline">${dadosRepo[i].watchers}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>`;
        }
    
        repositorios.innerHTML = strTextRepositorios;
    }
    

    // Função que carrega todos os dados referentes às informações gerais dos seguidores
    function CarregaDadosFollowers(dadosFollower) {
    var colegasPerfil = document.getElementById('followers');
    var strTextFollowers = '';

    for (let i = 0; i < 6; i++) {
        strTextFollowers += `<div class="d-inline-block col-2 text-info">
                            <a href="${dadosFollower[i].html_url}" target="_blank"><img src="${dadosFollower[i].avatar_url}" alt="Foto de um colega de trabalho" class="img-fluid flex-wrapmax-width-300 p-1 border "></a>
                            <p class="text-center">${dadosFollower[i].login}</p>
                        </div>`;
    }

    colegasPerfil.innerHTML = strTextFollowers;
    }

    function CarregaTelaRepos(dadosRepo){

        function extrairIdDaUrl(url) {
            const urlObj = new URL(url);
            const params = new URLSearchParams(urlObj.search);
            return params.get('id');
        }

        var idURL = extrairIdDaUrl(window.location.href);

        for (let i = 0; i < dadosRepo.length; i++) {
            if(dadosRepo[i].id == idURL){

                var nome_repo = document.getElementById('name_repositorio');
                var descricao_tela_repo = document.getElementById('descricao_repositorio');
                var data_criacao_repo = document.getElementById('data_criacao_repositorio');
                var linguagem_repo = document.getElementById('linguagens_repositorio');
                var link_acesso_repo = document.getElementById('link_repositorio');
                var topicos_repo = document.getElementById('topicos_repositorio');
                var strTextTopics = '';
                var numeroViews = document.getElementById('numero_views');
                var numeroFavoritos = document.getElementById('numero_favoritos');

                nome_repo.innerHTML = `<h2>Repositório: ${dadosRepo[i].name}</h2>`;
                descricao_tela_repo.innerHTML = `<p>${dadosRepo[i].description}</p>`;
                data_criacao_repo.innerHTML = `<p>${dadosRepo[i].created_at}</p>`;
                linguagem_repo.innerHTML = `<p>${dadosRepo[i].language}</p>`;
                link_acesso_repo.innerHTML = `<a href="${dadosRepo[i].html_url}" target="_blank"><p>${dadosRepo[i].html_url}</p></a>`
                
                for(let j = 0; j < dadosRepo[i].topics.length; j++){
                    strTextTopics += `<li class="d-inline-block"><div class="badge badge-info p-2 mx-1" style="width: 6rem;">${dadosRepo[i].topics[j]}</div></li>`;
                }
                topicos_repo.innerHTML = strTextTopics; 

                numeroViews.innerHTML = `<p>(${dadosRepo[i].watchers})</p>`;
                numeroFavoritos.innerHTML = `<p>(${dadosRepo[i].stargazers_counts})</p>`;
            }
        }
        
    }

    CarregaDadosAPI_Gerais(CarregaDadosGerais);
    CarregaDadosAPI_Gerais(CarregaDadosPerfil);
    CarregaDadosAPI_Repo(CarregaTelaRepos);
    CarregaDadosAPI_Repo(CarregaDadosRepo);
    CarregaDadosAPI_Followers(CarregaDadosFollowers);
}
    
CarregaTela();

//obs: como fazer o arquivo db.json
//obs: preciso colocar os icons num json?

//obs: precisa colocar foto na tela de repositórios?

//obs: favoritos na tela repositórios n aparece

//obs: footer n funciona na tela repositorios (pode ser ordem da chamada das funções ou a falta de chamar a função CarregaDadosGerais na tela repositórios)

//obs: colegas e conteúdos sugeridos não ficam responsivos, diminuem demais

//obs: perguntar sobre a parte: "Estrutura de dados", que está no enunciado 
