# Sonarqube and .NET Core - An example

## Steps to run in your local 

### 1. Run the docker compose

```docker-compose up```

### 2. Configure your application

#### 2.1. Configure a new application 

![Step 1](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar4.jpeg?raw=true)

As sugestion, [use this site to generate a random key](http://www.unit-conversion.info/texttools/random-string-generator/) (or any other).

#### 2.2. Create a token

![Step 2](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar5.jpeg?raw=true)

#### 2.3. Save the token generated

![Step 3](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar6.jpeg?raw=true)

#### 2.4. Copy the commands to simplify your job

![Step 4](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar6.jpeg?raw=true)


### 3. Start the sonnar scan

In console, run. See this example:

```dotnet sonarscanner begin /k:"23hrazeAvj7QKHs5555567uYlJ000WRIg9cTDM07Mn83JlXyHpDQTY10I9NXXSyF43G8E34pPS8AwWlFhsg7cSV8n3wjQ1nCvm6H" /d:sonar.host.url="http://localhost:9999" /d:sonar.login="1c6ca72effaec1449a526ef919ca564hyrdxb42b"```

### 4. Build your application

Ezzy: ```dotnet build```

### 5. Stop the sonnar scan

```dotnet sonarscanner end /d:sonar.login="1c6ca72effaec1449a526ef919ca564hyrdxb42b"```

### 6. After that, see the beautiful data generated on the administration page of Sonarqube

![Result 1](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar3.jpeg?raw=true)

![Result 2](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar1.jpeg?raw=true)

![Result 3](https://github.com/jcorreaviana/netcore-sonarqube/blob/master/infrastructure/pictures/sonar2.jpeg?raw=true)

## Enjoy!

#iswe