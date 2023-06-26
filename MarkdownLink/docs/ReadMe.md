
# Markdown Plugin- User Guide

## How it works!!!!

# Overview
 Feature is divided into 3 components. ( MarkdownLink, MarkdownParser and FormatConverter)
 1. MarkdownLink provides an interface to the client, where client can access "GetLinks()" method by passing root directory from where all md files should be read and output is stored in the form of XmlDocument.
 2. MarkdownParser is an implementation where all the md files are accessed mentioned inside the source md file from the root directory.
 3. FormatConverter will provide functionality to convert XmlDocument to various type formats e.g:"dgml","dot".....

![](MDPlugin.jpg)
          ![](LinksNodeEdgeCreator.jpg)


