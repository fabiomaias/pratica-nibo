# pratica-nibo
Avaliação prática Nibo

# build:
-- Acessar dir onde está a sulution e executar
docker build -f ./NiboOfx/Server/Dockerfile --force-rm -t nibo-ofx:latest .

# run: 
docker run -d --name nibo-ofx -p 8080:80
