docker build --no-cache -f SQL\Dockerfile.PostgreSql -t 12345-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t 12345-java/app ../../..
