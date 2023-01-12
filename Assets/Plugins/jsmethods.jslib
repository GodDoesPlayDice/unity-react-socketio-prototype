mergeInto(LibraryManager.library, {

  TalkToReact: function (message) {
    var parsedMessage = UTF8ToString(message);
    window.TalkToReact(parsedMessage);
  }, 
  
});