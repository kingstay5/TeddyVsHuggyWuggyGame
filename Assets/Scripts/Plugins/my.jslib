mergeInto(LibraryManager.library, {

  ShowAdv : function () {
    ysdk.adv.showFullscreenAdv({
      callbacks: {
        onClose: function(wasShown) {
          myGameInstance.SendMessage("Yandex", "VolumeOn");
        },
        onError: function(error) {
          myGameInstance.SendMessage("Yandex", "VolumeOn");
        }
      }
    })
  },

  RestartAdvExtern : function () {
    ysdk.adv.showFullscreenAdv({
      callbacks: {
        onClose: function(wasShown) {
          myGameInstance.SendMessage("Yandex", "RestartLevel");
        },
        onError: function(error) {
          myGameInstance.SendMessage("Yandex", "RestartLevel");
        }
      }
    })
  },

  RestartRewardExtern : function () {
    ysdk.adv.showRewardedVideo({
      callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage("Yandex", "RestartRewardAdv");
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
          myGameInstance.SendMessage("Yandex", "RestartLevelError");
        }
      }
    })
  },
  });