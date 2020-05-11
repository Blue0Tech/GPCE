echo 'Install GPCE (Note: GPCE will install in the working directory)? Y for yes: '
read -s -n 1 key
if [ "$key" = "Y" ] || [ "$key" = "y" ];then
    wget 'http://github.com/Blue0Tech/GPCE/archive/master.zip'
    [[ -f 'GPCE.zip' ]] && rm 'GPCE.zip'
    mv 'master.zip' 'GPCE.zip'
    [[ -d 'GPCE-master' ]] && rm -r 'GPCE-master'
    unzip 'GPCE.zip'
    [[ -d 'GPCE' ]] && rm -r 'GPCE'
    mv 'GPCE-master' 'GPCE'
    rm GPCE.zip
    rm 'GPCE/GPCEinstallerCS.exe'
    rm 'GPCE/index.html'
    rm 'GPCE/LICENSE'
    rm 'GPCE/GPCEinstallerCS.sh'
    rm 'GPCE/src/GPCEinstallerCS.cs'
    rm 'GPCE/src/GPCE.cs'
    mv 'GPCE/src/GPCE.exe' 'GPCE/GPCE.exe'
    mv 'GPCE/src/license.txt' 'GPCE/license.txt'
    rm -r 'GPCE/src'
fi