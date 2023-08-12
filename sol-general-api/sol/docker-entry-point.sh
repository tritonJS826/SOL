#!/bin/bash

echo "Collect static files"
python manage.py collectstatic --noinput

echo "Apply database migrations"
python manage.py migrate

echo "Starting server"
gunicorn --bind 0.0.0.0:8080 --timeout 600 core.wsgi
