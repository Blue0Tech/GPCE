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
    rm -r 'GPCE/Python 3'
    rm 'GPCE/GPCEinstallerCS.exe'
    rm 'GPCE/index.html'
    rm 'GPCE/LICENSE'
    rm 'GPCE/GPCEinstallerCS.sh'
    rm 'GPCE/CS/GPCEinstallerCS.cs'
    rm 'GPCE/CS/GPCE.cs'
    mv 'GPCE/CS/GPCE.exe' 'GPCE/GPCE.exe'
    mv 'GPCE/CS/license.txt' 'GPCE/license.txt'
    mv 'GPCE/CS/privacy.txt' 'GPCE/privacy.txt'
    mv 'GPCE/CS/tc.txt' 'GPCE/tc.txt'
    rm -r 'GPCE/CS'
fi