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

    // Função que carrega os dados referentes às informações da parte de perfil na tela de repositórios
    function CarregaDadosPerfilRepo(dadosGerais, dadosRepo){
        
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

    for (let i = 0; i < dadosFollower.length; i++) {
        strTextFollowers += `<div class="d-inline-block col-7 col-md-2 col-lg-2 text-info">
                            <a href="${dadosFollower[i].html_url}" target="_blank"><img src="${dadosFollower[i].avatar_url}" alt="Foto de um colega de trabalho" class="img-fluid flex-wrapmax-width-300 p-1 border "></a>
                            <p class="text-center">${dadosFollower[i].name}</p>
                        </div>`;
    }

    colegasPerfil.innerHTML = strTextFollowers;
    
    
    }

    // Função que carrega os dados do repositório escolhido na tela repo.html
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
                var perfilRepo = document.getElementById('perfil_repo');

                perfilRepo.innerHTML = `
                <div>
                    <h3 class="text-info mb-3">Proprietário: ${dadosGerais.name}</h3>

                    <div class="d-block">
                        <img src="assets/icons/favoritos.svg" alt="Icone de Favoritos">
                        <strong><p class="d-inline">Estrelas:</strong> ${dadosRepo[i].stargazers_counts}</p>
                    </div>

                    <div class="d-block">
                        <img src="assets/icons/pessoas.svg" alt="Icone de Pessoas">
                        <strong><p class="d-inline">Observadores:</strong> ${dadosRepo[i].watchers}</p>
                    </div>

                <strong><p>Fork:</strong> ${dadosRepo[i].forks}</p>

                <strong><p>Tipo de Licença:</strong> ${dadosRepo[i].license}</p>
                `;
            
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
    
    // Função que carrega os conteúdos sugeridos na tela index(principal)
    function CarregaDadosCarrossel(dadosCarrossel){

        console.log(dadosCarrossel)

        var fotosCarrossel = document.getElementById('fotos_carrossel');
        var carrosselIndicators = document.getElementById('carrossel_indicators');
        var strTextFotos = '';
        var strTextIndicators = '';

        for(let i = 0; i < dadosCarrossel.length; i++){
            if(i == 0){
                 strTextIndicators += `<button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="${i}" class="active" aria-current="true" aria-label="Slide ${i+1}"></button>`; 
            }else{
                 strTextIndicators += `<button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="${i}" aria-label="Slide ${i+1}"></button>`; 
            }
            
        }
        carrosselIndicators.innerHTML = strTextIndicators;

       
        
        for(let i = 0; i < dadosCarrossel.length; i++){
            if(i == 0){
            strTextFotos += `<div class="carousel-item active">
                <a href="${dadosCarrossel[i].url}" target="_blank"><img src="${dadosCarrossel[i].imagem}" class="d-block w-100" alt="${dadosCarrossel[i].alt}"></a>
                <div class="carousel-caption d-none d-md-block">
                  <h5>${dadosCarrossel[i].title}</h5>
                  <p>${dadosCarrossel[i].description}</p>
                </div>
              </div>`;  
            }else{
                strTextFotos += `<div class="carousel-item">
                    <a href="${dadosCarrossel[i].url}" target="_blank"><img src="${dadosCarrossel[i].imagem}" class="d-block w-100" alt="${dadosCarrossel[i].alt}"></a>
                    <div class="carousel-caption d-none d-md-block">
                      <h5>${dadosCarrossel[i].title}</h5>
                      <p>${dadosCarrossel[i].description}</p>
                    </div>
                  </div>`; 
            }
        }
        fotosCarrossel.innerHTML = strTextFotos;
         console.log(strTextFotos)
    }

    CarregaDadosAPI_Gerais(CarregaDadosGerais);
    CarregaDadosAPI_Gerais(CarregaDadosPerfil);
    CarregaDadosAPI_Gerais(CarregaDadosPerfilRepo);
    CarregaDadosAPI_Repo(CarregaTelaRepos);
    CarregaDadosAPI_Repo(CarregaDadosRepo);
    CarregaDadosAPI_Followers(CarregaDadosFollowers);
    CarregaDadosAPI_Carrossel(CarregaDadosCarrossel);
}
    
CarregaTela();
 