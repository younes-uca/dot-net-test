## Build the project
.\mvnw clean package -DskipTests

## Create The Docker Image
docker build -t :v1 .

## Display The created Image
docker images

## Run the Container
docker run -d -p 8037:8037 --name -v1 :v1

## Display The Running Container
docker ps


