#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

#ifdef __cplusplus
extern "C" {
#endif

void setBrightness(float val) { [UIScreen mainScreen].brightness = val; }

#ifdef __cplusplus
}
#endif
