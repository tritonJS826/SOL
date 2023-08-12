## Installation

### Run in Docker

1. Clone this repo `git clone https://gitlab.com/itpm-chat-bot/bot-backend.git` and go to it's root folder.
2. Rename `.env.template` file in the root folder to `.env` and fill it in.
3. Run `docker compose up -d`
4. Optional: create admin user with a command `docker exec -it django_api python manage.py createsuperuser`
5. It's available at http://localhost:8080

### Install for development

Prerequisites: PostgreSQL Database, Python 3.10 and pip

1. Clone this repo.
2.1 Create virtual environment: `python3 -m venv python-venv`
2.2 Activate the virtual environment: `source python-venv/bin/activate`
2.3 Install dependencies: `pip install -r requirements.txt` and `pip install -r requirements-dev.txt`
3. Set up Git pre-commit hooks: `pre-commit install` and `pre-commit install --hook-type pre-push`
4. Copy `.env.template` to `.env` in `admin_panel/config` directory and fill it in.
5. Create migrations `python manage.py makemigrations general`
6. Apply migrations: `python manage.py migrate`
7. Run server: `python manage.py runserver`
8. The service will be available at http://localhost:8000

### Run tests

For running tests you should perform steps 1-4 from the previous section and then run `pytest` in the root directory.

## Logging

The logs are shown in docker-compose logs or with `docker logs <container_name>`. You can also use `docker-compose logs -f` to follow the logs.

## API

The API is documented with OpenAPI. You can find the documentation at https://account.itpm.info/api/schema/swagger-ui/.

The OpenAPI schema is available in `admin_panel/openapi.yaml` file.

## Deployment

The service is deployed to the server with Docker and docker-compose. The deployment is done with GitLab CI/CD.


## Contributing

### Code style

All code should be formatted with Black before committing. It's done automatically with pre-commit hook. You can also run it manually with `black admin_panel` command.
