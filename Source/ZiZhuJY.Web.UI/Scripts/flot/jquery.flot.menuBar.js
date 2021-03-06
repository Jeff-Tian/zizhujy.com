﻿/* Flot plugin that adds some menu buttons on top of the canvas layer to allow users do some advanced operations like save current graph, etc.

Copyright (c) 2013 http://zizhujy.com.
Licensed under the MIT license.

Usage:
Inside the <head></head> area of your html page, add the following line:

<script type="text/javascript" src="http://zizhujy.com/Scripts/flot/jquery.flot.menuBar.js"></script>

Now you are all set, there will be menu bar appear on your canvas.

Online examples:
http://zizhujy.com/FunctionGrapher is using it.

Dependencies:
    This plugin references the base64.js and canvas2image.js.

Customizations:
    options = {
        homeRange: {xmin:-10,xmax:10,ymin:-10,ymax:10},
        panAmount: 100,
        zoomAmount: 1.5,
        position: {left: "20px", top: "20px"}
    };

    <ul>
        <li>Menu 1</li>
        <li>
            Menu 2
            <ul>
                <li>Sub menu 1</li>
                <li event='click' handler='handler'>Sub menu 2</li>
                <li>Sub menu 3</li>
            </ul>
        </li>
        <Li>
            Menu 3
        </li>
    </ul>

*/

; (function ($, Canvas2Image, Globalize) {
    var thePlot = null;
    var theClasses = null;
    var mergedCanvas = null;

    function init(plot, classes) {
        thePlot = plot;
        theClasses = classes;

        plot.hooks.draw.push(drawMenuBar);

        plot.hooks.shutdown.push(shutdown);
    }

    function drawMenuBar(plot, canvascontext) {
        var $placeholder = plot.getPlaceholder();
        if ($placeholder.find("ul.menu-bar").length <= 0) {
            var $menuBar = $(plot.getOptions().menu.menuHtml);
            if (!$menuBar.hasClass("menu-bar")) $menuBar.addClass("menu-bar");
            $menuBar.appendTo($placeholder);

            // css
            $menuBar.css({
                "left": plot.getOptions().menu.position.left,
                "top": plot.getOptions().menu.position.top
            });

            $("ul.menu-bar, ul.menu-bar ul").css({
                "list-style-type": "none",
                "margin": "0",
                "padding": "0",
                "height": "auto",
                "overflow": "visible",
                "position": "absolute",
                "z-index": "100",
                "color": "#666",
                "width": "auto"
            });

            $("ul.menu-bar > li").css({
                "float": "left",
                "border": "solid 1px #666",
                "border-radius": "5px",
                "box-sizing": "border-box",
                "height": "28px",
                "line-height": "28px",
                "width": "28px",
                "margin-right": "1px",
                "cursor": "pointer",
                "text-align": "center",
                "vertical-align": "middle",
                "text-shadow": "0 1px 1px rgba(100, 100, 100, 0.75)",
                "background-color": "#f5f5f5",
                "box-shadow": "0 0 4px rgba(0, 0, 0, 0.15)",
                "-webkit-box-shadow": "0 0 4px rgba(0, 0, 0, 0.15)",
                "display": "inline-block"
            });

            $("ul.menu-bar li span.helper").css({
                "display": "inline-block",
                "height": "100%",
                "vertical-align": "middle",
                "position": "relative"
            });

            // jquery: Syntax error, unrecognized expression: unsupported pseudo: hover
            /*
            $("ul.menu-bar li:hover").css({
                "color": "black",
                "background-color": "white"
            });*/

            $("ul.menu-bar ul").css({
                "display": "none",
                "width": "auto",
                "margin-top": "-1px"
            });

            $("ul.menu-bar ul li").css({
                "border": "solid 1px black",
                "border-collapse": "collapse",
                "display": "inline-block",
                "width": "100%",
                "white-space": "nowrap",
                "padding": "0 5px",
                "margin-top": "-1px",
                "background-color": "#f5f5f5",
                "overflow": "visible",
                "text-align": "left"
            });

            $("ul.menu-bar").append("<li class='clearFloat'></li>");

            // behaviors hooks
            $("ul.menu-bar")
                .on("mouseover", "li", function (e) { showSubMenus(this); })
                .on("mouseout", "li", function (e) { hideSubMenus(this); })
            ;//.live("click", function(e){handleSubMenus(this);});

            $("ul.menu-bar li").each(function (index, li) {
                var handler = $(li).attr("handler");
                var event = $(li).attr("event");
                if (event && event != "" && handler && handler != "") {
                    $(li).bind(event, eval(handler));
                }
            });

            // behaviors implementation
            function showSubMenus(context) {
                var $subMenus = $(context).find("ul");
                $subMenus.show();

                $(context).css({
                    "background-color": "white",
                    "color": "black"
                });
            }

            function hideSubMenus(context) {
                var $subMenus = $(context).find("ul");
                $subMenus.hide();

                $(context).css({
                    "background-color": "#f5f5f5",
                    "color": "#666"
                });
            }

            function handleSubMenus(context) {
                var $subMenus = $(context).find("ul");
                if ($subMenus.is(":visible")) {
                    hideSubMenus(context);
                } else {
                    showSubMenus(context);
                }
            }
        }
    }

    function shutdown(plot, eventHolder) {
        var $placeholder = plot.getPlaceholder();
        var $menuBar = $placeholder.find("ul.menu-bar");
        if ($menuBar.length > 0) {
            $("ul.menu-bar li").each(function (index, li) {
                var handler = $(li).attr("handler");
                var event = $(li).attr("event");
                if (event && event != "" && handler && handler != "") {
                    $(li).unbind(event);
                }
            });
        }

        $menuBar.remove();
    }

    // event handlers    
    function test() {
        alert("hello");
    }

    function saveAsPng() {
        if (thePlot) {
            mergedCanvas = mergeCanvases(thePlot);

            Canvas2Image.saveAsPNG(mergedCanvas, false);
        }

        setTimeout(function () { deleteStaleCanvasImage(thePlot, mergedCanvas); }, 500);
    }

    function saveAsJpeg() {
        if (thePlot) {
            mergedCanvas = mergeCanvases(thePlot);

            Canvas2Image.saveAsJPEG(mergedCanvas, false);
        }

        setTimeout(function () { deleteStaleCanvasImage(thePlot, mergedCanvas); }, 500);
    }

    function saveAsBmp() {
        if (thePlot) {
            mergedCanvas = mergeCanvases(thePlot);

            Canvas2Image.saveAsBMP(mergedCanvas, false);
        }

        setTimeout(function () { deleteStaleCanvasImage(thePlot, mergedCanvas); }, 500);
    }

    function deleteStaleCanvasImage(plot, mergedCanvas) {
        if (!!mergedCanvas) {
            $(mergedCanvas).remove();
        }
        $(".mergedCanvas").remove();
    }

    function mergeCanvases(plot) {

        var theMergedCanvas = plot.getCanvas();

        if (!!theClasses) {
            theMergedCanvas = new theClasses.Canvas("mergedCanvas", plot.getPlaceholder());
            var mergedContext = theMergedCanvas.context;

            $(theMergedCanvas).css({
                "visibility": "hidden",
                "z-index": "-100",
                "position": "absolute"
            });

            var $canvases = $(plot.getPlaceholder()).find("canvas");
            $canvases.each(function (index, canvas) {
                mergedContext.drawImage(canvas, 0, 0);
            });

            return theMergedCanvas.element;
        }

        return theMergedCanvas;
    }

    function showNavigationControl() {
        if (thePlot) {
            $(thePlot.getPlaceholder()).find(".navigation-control").css({
                "display": "block"
            });

            $.extend(true, thePlot.getOptions(), { navigationControl: { display: "block" } });
        }
    }

    function hideNavigationControl() {
        if (thePlot) {
            $(thePlot.getPlaceholder()).find(".navigation-control").css({
                "display": "none"
            });

            thePlot.getOptions().navigationControlDisplay = "none";
        }
    }

    function handleNavigationControl() {
        if (thePlot) {
            var display = $(thePlot.getPlaceholder()).find(".navigation-control").css("display");
        }

        if (display != "none") {
            hideNavigationControl();
        } else {
            showNavigationControl();
        }
    }

    function fullScreen() {
        if ($("#main > #app").length > 0) {
            return true;
        }

        var element = document.body;
        var requestMethod = element.requestFullScreen || element.webkitRequestFullScreen || element.mozRequestFullScreen || element.msRequestFullScreen;
        var isInFullScreen = (document.fullScreenElement && document.fullScreenElement !== null) || (document.mozFullScreen || document.webkitIsFullScreen);

        if (isInFullScreen) {
            var exitFullScreen = document.exitFullscreen || document.mozCancelFullScreen || document.webkitCancelFullScreen;
            exitFullScreen.call(document);
        } else {
            if (requestMethod) {
                requestMethod.call(element);
            } else if (typeof window.ActiveXObject !== "undefined") {
                // Older IE.
                try {
                    var wscript = new ActiveXObject("WScript.Shell");
                    if (wscript !== null) {
                        wscript.SendKeys("{F11}");
                    }
                } catch (ex) {
                }
            }
        }

        return false;
    }

    var options = {
        menu: {
            position: { left: "20px", top: "10px" },
            menuHtml: "<ul class='menu-bar'><li event='click' handler='fullScreen' title='{5}'><span class='helper'></span><a href='http://zizhujy.com/FunctionGrapher?src=baiduApp' target='_blank' style='text-decoration: none; color: #666;'><span class='icon' style='font-size: larger;'>f</span></a></li><li title='{4}' event='click' handler='handleNavigationControl'><span class='helper'></span><span class='icon' style='font-size: larger;'>m</span></li><li title='{0}'><span class='helper'></span><span class='icon' style='font-size: larger'>&#xe001;</span><ul><li event='click' handler='saveAsPng'>{1}</li><li event='click' handler='saveAsJpeg'>{2}</li><li event='click' handler='saveAsBmp'>{3}</li></ul></li></ul>".format(
                Globalize.localize("TipForSavingGraph") || "Save as image...",
                Globalize.localize("SaveAsPNG") || "Save as PNG...",
                Globalize.localize("SaveAsJPEG") || "Save as JPEG...",
                Globalize.localize("SaveAsBMP") || "Save as BMP...",
                Globalize.localize("ToggleNavigationControl") || "Toggle navigation control",
                Globalize.localize("FullScreen") || "Full screen"
            )
        }
    };

    $.plot.plugins.push({
        init: init,
        options: options,
        name: 'menuBar',
        version: '0.6'
    });
})(jQuery, Canvas2Image, Globalize);