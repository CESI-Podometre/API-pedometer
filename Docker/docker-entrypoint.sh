#!/bin/sh

echo "Entrypoint script for StarFitApi"

if [ "$DOTNET_ENV" = "development" ];
then
    echo "Installing dependencies"
    dotnet restore
fi

exec "$@"