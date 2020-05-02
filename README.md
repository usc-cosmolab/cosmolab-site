# Welcome to the USC CosmoLab site code

This repository contains the code for the cosmolab website including a visualization that runs on the backend server. It continuously integrates with the server via Team City, so any changes made here should automatically update the site at cosmolab.usc.edu within a few minutes of the push.

The documentation below will show you how to dig right in to making changes to the site. Further down you'll see the high-level structure of the code as well as the relevant technologies.


# Making changes

To do this, all you need is a text editor. Notepad and TextEdit work! You could even edit files from within the GitHub web interface. In case you don't have a favorite text editor for development, I'd recommend [Visual Studio Code](https://code.visualstudio.com/).

## Modifying webpages
In the repo, navigate to [clv-mvc/Views/Home/](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/Views/Home). This is where all user-facing web content is. You'll find a bunch of .cshtml files--they're just like html files with added C# integration so it can connect with the backend. These files focus on just the content of the webpage, so it's easier to find what to edit.

As an example, go to *Index.cshtml*. Here, the text you see enclosed within a `<p>` tag is a paragraph. Make some changes here, commit, and push. The homepage will reflect these changes shortly.

More documentation is coming soon.
