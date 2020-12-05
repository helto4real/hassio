service dbus start
service bluetooth start
if [ "$(ls -A $DIR)" ]; then
     echo "Scripts and settings allready created. Continuing..."
else
    echo "Init scripts for the first time, copy scripts and settings..."
    cp -R /scripts/* /app
fi

( exec "/app/presence.sh" -d )