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

## Changing colors and styles

This one's a bit more tricky because you may have to edit the CSS - short for Cascading Styling Sheet. This file, which you can find at [clv-mvc/wwwroot/css/site.css](https://github.com/usc-cosmolab/cosmolab-site/blob/master/clv-mvc/wwwroot/css/site.css) is meant to decouple the content from styling; however, in modern HTML, this is not always the case. You'll generally find most styling info like colors in the CSS file.
As an example, at the time of this commit, site.css contains the following code:

    .custom-hyperlink {
	    color: #0A84FF;
	    font-size: 1.2rem;
	    font-weight: bold
    }
This code defines a style class called custom-hyperlink that can now be applied to an element on any html page. That element will then have all these properties applied to it. This class is used in Contact.cshtml like this:

    <a  class="custom-hyperlink" href="mailto:abc@usc.edu">abc@usc.edu</a>
This means that the element of type a (used for hyperlinks, don't ask why) uses the class custom-hyperlink for styling and has the hyperlink specified as href applied to it. You can try changing the color in the css using a hex code or the font weight. Note that font-size is relative to a global variable *rem*. Above, it's 1.2 times *rem*. You can experiment with it till you find a suitable factor.
Please be warned that CSS can be a **pain** especially because different browsers implement CSS properties differently; so, something as simple as changing size may need a lot of tweaking.
![What CSS feels like](https://2.bp.blogspot.com/-41v6n3Vaf5s/UeRN_XJ0keI/AAAAAAAAN2Y/YxIHhddGiaw/s1600/css.gif)
Which brings us to a better solution for styling, the Bootstrap framework. This is something that this project uses and you can use predefined CSS classes from Bootstrap to make style changes rather easily. Bootstrap handles all the cross-browser stuff and fixes edges.

## Using the Bootstrap framework

Boostrap handles styling, responsiveness (scaling as the browser or screen size increases), and more.

**More documentation is coming soon.**
