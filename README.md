# unitybuildtest

This is just a test project for GitHub Actions for Unity so I can automatically have a build of the game upon a commit and automatically upload to itch.io.

Feel free to use this in your own projects. The most important information for you to know is that what you're looking for is in the .github/workflows folder. If you want documentation on the CI system then visit https://game.ci/ 

You don't have to use Cloudflare R2 to store your builds. You can use GitHub Actions artifacts but I choose not to use it because of the limited storage space for private repositories. If you want to know how to use GitHub Actions, you should visit the Game CI website I linked above.

You will also have to add the following secrets in order for the CI system to work:
- BUTLER_CREDENTIALS - for pushing to itch.io using the butler command line tool
- R2_ACCESS_KEY_ID - Cloudflare R2
- R2_ACCOUNT_ID - Cloudflare R2
- R2_SECRET_ACCESS_KEY - Cloudflare R2
- UNITY_EMAIL - Email of your Unity account for Game CI (visit the Game CI website for why this is required)
- UNITY_PASSWORD - Password of your Unity account (see above)
- UNITY_LICENSE - Unity license website (visit Game CI website for more information and how to acquire it)
