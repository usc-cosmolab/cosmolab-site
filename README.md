# Welcome to the USC CosmoLab site code

This repository contains the code for the cosmolab website including a visualization that runs on the backend server. It continuously integrates with the server via Team City, so any changes made here should automatically update the site at cosmolab.usc.edu within a few minutes of the push.

The documentation below will show you how to dig right in to making changes to the site. Further down you'll see the high-level structure of the code as well as the relevant technologies.


# Making changes

To do this, all you need is a text editor. Notepad and TextEdit work! You could even edit files from within the GitHub web interface. In case you don't have a favorite text editor for development, I'd recommend [Visual Studio Code](https://code.visualstudio.com/).

## Modifying webpages
In the repo, navigate to [clv-mvc/Views/Home/](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/Views/Home). This is where all user-facing web content is. You'll find a bunch of .cshtml files--they're just like html files with added C# integration so it can connect with the backend. These files focus on just the content of the webpage, so it's easier to find what to edit.

As an example, go to *Index.cshtml*. Here, the text you see enclosed within a `<p>` tag is a paragraph. Make some changes here, commit, and push. The homepage will reflect these changes shortly.


## Adding images and other non-text content

This time, you navigate to [clv-mcv/wwwroot/](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/wwwroot) and find the files there. At the top-level, you will find the background image, placeholder image, and more. When you're referring to this content from the html or css code, the path is relative to this folder. For example, the file *People.cshtml* from the previous section has the following line in it:

    <img  style="max-width: 75%;"  src="~/placeholder.png"  class="rounded-heavy img-fluid"  alt="..." />
In this line, `src="~/placeholder.png"` defines the path to the *source* of the file relative to the wwwroot folder. So, you can upload a new image here to be used in place of the placeholder and change the path to it.

I'll cover more advanced edits later on in this document.

**More documentation is coming soon.**
