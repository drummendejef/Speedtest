cd "c:/Program Files (x86)/GnuWin32/bin"
echo "$PWD"

"c:/Program Files (x86)/GnuWin32/bin/wget.exe" http://speedtest.wdc01.softlayer.com/downloads/test10.zip 2>> "c:/Users/Admin/AppData/Local/VirtualStore/Program Files (x86)/GnuWin32/bin/testje.txt"

tail "c:/Users/Admin/AppData/Local/VirtualStore/Program Files (x86)/GnuWin32/bin/testje.txt" -n2 | head -n1 >> "c:/Users/Admin/AppData/Local/VirtualStore/Program Files (x86)/GnuWin32/bin/testje2.txt"


cd "c:/Users/Admin/AppData/Local/VirtualStore/Program Files (x86)/GnuWin32/bin"
rm test10.zip

sleep 10