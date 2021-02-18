source: https://hackernoon.com/adding-web-config-to-react-projects-3eb762dbe01f

In case we build project with react scripts
1. Create **`iisConfig`** folder in the project root.
2. Put **`web.config`** file into the **`iisConfig`** folder
```xml
<?xml version="1.0" encoding="UTF-8"?>
<configuration>
    <system.webServer>
		<rewrite>
            <rules>
                <rule name="ReactRouter Routes" stopProcessing="true">
                    <match url=".*" />
                    <conditions logicalGrouping="MatchAll">
                        <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
                        <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />
                    </conditions>
                    <action type="Rewrite" url="/index.html" />
                </rule>
		  </rules>
		</rewrite>		
        <httpRedirect enabled="false" />
    </system.webServer>
</configuration>
```
3. Put **`copyIISConfig.js`** file into the **`iisConfig`** folder
```javascript
const fs = require('fs-extra');

const webConfigPath = './build/web.config';

if (fs.existsSync(webConfigPath)) {
    fs.unlinkSync(webConfigPath);
}

fs.copySync('./iisConfig/web.config', webConfigPath);
```
5. In the **`package.json`** file inside the `scripts` part add the additional build step on the postbuild event:
```json
"scripts": {
	"start": "react-scripts start",
	"build": "react-scripts build",
	"test": "react-scripts test",
	"eject": "react-scripts eject",
	"postbuild": "node iisConfig/copyIISConfig.js"
},
```
