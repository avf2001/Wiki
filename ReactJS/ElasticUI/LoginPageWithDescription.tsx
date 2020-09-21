import {
  EuiFlexGroup,
  EuiFlexItem,
  EuiPanel,
  EuiForm,
  EuiFormRow,
  EuiFieldText,
  EuiSpacer,
  EuiButton,
  EuiCallOut,
} from "@elastic/eui";
import React from "react";

const Login = () => {
  return (
    <EuiFlexGroup gutterSize="none" justifyContent="spaceAround">
      <EuiFlexItem grow={false} style={{ minWidth: 700, maxWidth: 700 }}>
        <EuiPanel style={{ marginTop: 200 }}>
          <EuiFlexGroup>
            <EuiFlexItem>
              <EuiForm component="form">
                <EuiFormRow label="Логин">
                  <EuiFieldText width={15} />
                </EuiFormRow>
                <EuiFormRow label="Пароль">
                  <EuiFieldText />
                </EuiFormRow>
                <EuiSpacer />
                <EuiButton type="submit" fill>
                  Войти
                </EuiButton>
              </EuiForm>
            </EuiFlexItem>
            <EuiFlexItem>
              <EuiCallOut
                title="Good news, everyone!"
                color="success"
                iconType="user"
              >
                <p>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin
                  eu consectetur risus, sed condimentum magna. Pellentesque
                  velit nunc, accumsan vitae diam vel, vestibulum sagittis
                  felis. Ut et posuere eros. Integer ut quam sagittis, suscipit
                  neque in, mollis felis. Nulla tincidunt ex condimentum lorem
                  congue volutpat. Suspendisse id finibus tellus, a eleifend
                  ipsum. Phasellus tempor erat urna, et vulputate nisl sodales
                  nec. Vivamus dictum scelerisque est at malesuada. Nullam eget
                  venenatis libero, in sodales risus. Mauris euismod blandit
                  lobortis. Suspendisse eu viverra magna, ut consectetur elit.
                  Sed sed libero sapien. Fusce consectetur lacus tortor, in
                  ultrices enim tempus at.
                </p>
              </EuiCallOut>
            </EuiFlexItem>
          </EuiFlexGroup>
        </EuiPanel>
      </EuiFlexItem>
    </EuiFlexGroup>
  );
};

export default Login;
