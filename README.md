# Welcome to the USC CosmoLab site code

This repository contains the code for the cosmolab website including a visualization that runs on the backend server. It continuously integrates with the server via Team City, so any changes made here should automatically update the site at cosmolab.usc.edu within a few minutes of the push.

The documentation below will show you how to dig right in to making changes to the site. Further down you'll see the high-level structure of the code as well as the relevant technologies.


# Making changes

To do this, all you need is a text editor. Notepad and TextEdit work! You could even edit files from within the GitHub web interface. In case you don't have a favorite text editor for development, I'd recommend [Visual Studio Code](https://code.visualstudio.com/).

## Modifying webpages
In the repo, navigate to [clv-mvc/Views/Home/](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/Views/Home). This is where all user-facing web content is. You'll find a bunch of .cshtml files--they're just like html files with added C# integration so it can connect with the backend. These files focus on just the content of the webpage, so it's easier to find what to edit.

As an example, go to *Index.cshtml*. Here, the text you see enclosed within a `<p>` tag is a paragraph. Make some changes here, commit, and push. The homepage will reflect these changes shortly.


## Adding images and other non-text content

This time, you navigate to [clv-mvc/wwwroot/](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/wwwroot) and find the files there. At the top-level, you will find the background image, placeholder image, and more. When you're referring to this content from the html or css code, the path is relative to this folder. For example, the file *People.cshtml* from the previous section has the following line in it:

    <img  style="max-width: 75%;"  src="~/placeholder.png"  class="rounded-heavy img-fluid"  alt="..." />
In this line, `src="~/placeholder.png"` defines the path to the *source* of the file relative to the wwwroot folder. So, you can upload a new image here to be used in place of the placeholder and change the path to it.

## Modifying the layout
We have only one file containing the main layout of the site. This way, we do not have to modify the sidebar entries in every single html file when we make a change. Less work (for you), more convolution, great tradeoff!
Find the *_Layout.cshtml* file in [clv-mvc/Views/Shared](https://github.com/usc-cosmolab/cosmolab-site/tree/master/clv-mvc/Views/Shared). Here you'll find everything but the main content of each page. A bunch of `<div>` elements (**div**isions) with the class `nav-item` are the containers for the sidebar elements.
You can delete entire nav-items or modify their contents. The `asp-action="Example"` attribute defines what the link points to, while the text "Home" that's contained within the `div` with the attribute `name="hamburger_names"` is the text that appears. You can change this text without affecting the link.

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

Bootstrap handles styling, responsiveness (scaling as the browser or screen size increases), and more. One thing you'll notice is we'll work a lot with relative sizes in percentages. This is because we live in a multi-screen world where 300px might look like a small portion of the page on your computer but it'll be almost the entire page on your phone.

There are two main Bootstrap concepts that will help you write and edit HTML code:

 - Classes: Bootstrap offers many built-in CSS classes that you can apply to your existing HTML elements. For example, in *Research.cshtml*, each "li" element (i.e. list item) specifies `text-light` as one of its classes. `text-light` is a bootstrap class that changes the text color to a white (or offwhite) color. Bootstrap contains many such classes (including some that modify how an element scales or what part of the screen its on) that you can find on the [Bootstrap documentation](https://getbootstrap.com/docs/4.4/getting-started/introduction/). Click on the relevant area in the left pane.
 - Layout: This is more tricky. In essence, Bootstrap functions with a system of invisible rows and columns in which it divides a webpage.
     - Columns: Each page is divided into 12 columns. Say you want text occupying 3/4ths of the width of a page and a picture in the 1/4th on the right. You do this by making two columns, one occupying the space of 9 columns, and the other occupying 3 columns. So, you have two `<div>` elements, one of whose class is set to `col-9` and the other to `col-3` for a total of 12. Not incidentally, this is exactly the setup you see in *Research.cshtml* (as well as other files). In real world usage, it's a little different. The second div is set to `col-3` (ignore the `lg`). The first one is set to simply `col` which gives it the rest of the pie (i.e. 12-3=9).
     - Rows: Likewise, you can define rows. These rows are unlimited and don't add up to anything as webpages typically allow unlimited vertical space (as vertical scrolling is more natural than horizontal). Bootstrap will attempt to keep everything in a row together. On small screens, content may be wrapped around to a new line. You can find an example of row usage in *_Layout.cshtml*. Each item in the left pane is one row.

**More documentation is coming soon.**
