import type { CustomThemeConfig } from '@skeletonlabs/tw-plugin';

export const myCustomTheme: CustomThemeConfig = {
    name: 'my-custom-theme',
    properties: {
		// =~= Theme Properties =~=
		"--theme-font-family-base": `system-ui`,
		"--theme-font-family-heading": `system-ui`,
		"--theme-font-color-base": "0 0 0",
		"--theme-font-color-dark": "0 0 0",
		"--theme-rounded-base": "9999px",
		"--theme-rounded-container": "8px",
		"--theme-border-base": "1px",
		// =~= Theme On-X Colors =~=
		"--on-primary": "255 255 255",
		"--on-secondary": "0 0 0",
		"--on-tertiary": "0 0 0",
		"--on-success": "0 0 0",
		"--on-warning": "0 0 0",
		"--on-error": "0 0 0",
		"--on-surface": "0 0 0",
		// =~= Theme Colors  =~=
		// primary | #000000 
		"--color-primary-50": "217 217 217", // #d9d9d9
		"--color-primary-100": "204 204 204", // #cccccc
		"--color-primary-200": "191 191 191", // #bfbfbf
		"--color-primary-300": "153 153 153", // #999999
		"--color-primary-400": "77 77 77", // #4d4d4d
		"--color-primary-500": "0 0 0", // #000000
		"--color-primary-600": "0 0 0", // #000000
		"--color-primary-700": "0 0 0", // #000000
		"--color-primary-800": "0 0 0", // #000000
		"--color-primary-900": "0 0 0", // #000000
		// secondary | #FFA500 
		"--color-secondary-50": "255 242 217", // #fff2d9
		"--color-secondary-100": "255 237 204", // #ffedcc
		"--color-secondary-200": "255 233 191", // #ffe9bf
		"--color-secondary-300": "255 219 153", // #ffdb99
		"--color-secondary-400": "255 192 77", // #ffc04d
		"--color-secondary-500": "255 165 0", // #FFA500
		"--color-secondary-600": "230 149 0", // #e69500
		"--color-secondary-700": "191 124 0", // #bf7c00
		"--color-secondary-800": "153 99 0", // #996300
		"--color-secondary-900": "125 81 0", // #7d5100
		// tertiary | #FFA500 
		"--color-tertiary-50": "255 242 217", // #fff2d9
		"--color-tertiary-100": "255 237 204", // #ffedcc
		"--color-tertiary-200": "255 233 191", // #ffe9bf
		"--color-tertiary-300": "255 219 153", // #ffdb99
		"--color-tertiary-400": "255 192 77", // #ffc04d
		"--color-tertiary-500": "255 165 0", // #FFA500
		"--color-tertiary-600": "230 149 0", // #e69500
		"--color-tertiary-700": "191 124 0", // #bf7c00
		"--color-tertiary-800": "153 99 0", // #996300
		"--color-tertiary-900": "125 81 0", // #7d5100
		// success | #00ff00 
		"--color-success-50": "217 255 217", // #d9ffd9
		"--color-success-100": "204 255 204", // #ccffcc
		"--color-success-200": "191 255 191", // #bfffbf
		"--color-success-300": "153 255 153", // #99ff99
		"--color-success-400": "77 255 77", // #4dff4d
		"--color-success-500": "0 255 0", // #00ff00
		"--color-success-600": "0 230 0", // #00e600
		"--color-success-700": "0 191 0", // #00bf00
		"--color-success-800": "0 153 0", // #009900
		"--color-success-900": "0 125 0", // #007d00
		// warning | #FFFF00 
		"--color-warning-50": "255 255 217", // #ffffd9
		"--color-warning-100": "255 255 204", // #ffffcc
		"--color-warning-200": "255 255 191", // #ffffbf
		"--color-warning-300": "255 255 153", // #ffff99
		"--color-warning-400": "255 255 77", // #ffff4d
		"--color-warning-500": "255 255 0", // #FFFF00
		"--color-warning-600": "230 230 0", // #e6e600
		"--color-warning-700": "191 191 0", // #bfbf00
		"--color-warning-800": "153 153 0", // #999900
		"--color-warning-900": "125 125 0", // #7d7d00
		// error | #ff0000 
		"--color-error-50": "255 217 217", // #ffd9d9
		"--color-error-100": "255 204 204", // #ffcccc
		"--color-error-200": "255 191 191", // #ffbfbf
		"--color-error-300": "255 153 153", // #ff9999
		"--color-error-400": "255 77 77", // #ff4d4d
		"--color-error-500": "255 0 0", // #ff0000
		"--color-error-600": "230 0 0", // #e60000
		"--color-error-700": "191 0 0", // #bf0000
		"--color-error-800": "153 0 0", // #990000
		"--color-error-900": "125 0 0", // #7d0000
		// surface | #FBB900 
		"--color-surface-50": "0 0 0", // #fef5d9
		"--color-surface-100": "254 241 204", // #fef1cc
		"--color-surface-200": "254 238 191", // #feeebf
		"--color-surface-300": "253 227 153", // #fde399
		"--color-surface-400": "252 206 77", // #fcce4d
		"--color-surface-500": "251 185 0", // #FBB900
		"--color-surface-600": "226 167 0", // #e2a700
		"--color-surface-700": "188 139 0", // #bc8b00
		"--color-surface-800": "151 111 0", // #976f00
		"--color-surface-900": "251 185 0", // #7b5b00
		
	}
}